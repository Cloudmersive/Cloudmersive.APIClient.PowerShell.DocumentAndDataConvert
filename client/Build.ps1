function Get-FunctionsToExport {
    [CmdletBinding()]
    Param (
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true)]
        [ValidateNotNullOrEmpty()]
        [Alias('FullName')]
        $Path
    )

    Process {
        $Token = $null
        $ParserErr = $null

        $Ast = [System.Management.Automation.Language.Parser]::ParseFile(
            $Path,
            [ref]$Token,
            [ref]$ParserErr
        )

        if ($ParserErr) {
            throw $ParserErr
        } else {
            foreach ($name in 'Begin', 'Process', 'End') {
	            foreach ($Statement in $Ast."${name}Block".Statements) {
		            if (
                        [String]::IsNullOrWhiteSpace($Statement.Name) -or
                        $Statement.Extent.ToString() -notmatch
                        ('function\W+{0}' -f $Statement.Name)
                    ) {
			            continue
		            }

		            $Statement.Name
	            }
            }
        }
    }
}

$ScriptDir = Split-Path $script:MyInvocation.MyCommand.Path
$ClientPath = ("$ScriptDir\csharp\SwaggerClient" | Resolve-Path).ProviderPath
$FunctionPath = 'API', 'Model' | ForEach-Object {Join-Path "$ScriptDir\src\cloudmersiveConvert\" $_}
$BinPath = "$ScriptDir\src\cloudmersiveConvert\Bin"

Start-Process -FilePath "$ClientPath\build.bat" -WorkingDirectory $ClientPath -Wait -NoNewWindow

if (!(Test-Path "$ScriptDir\src\cloudmersiveConvert\Bin" -PathType Container)) {
    New-Item "$ScriptDir\src\cloudmersiveConvert\Bin" -ItemType Directory > $null
}

Copy-Item "$ClientPath\bin\*.dll" $BinPath

$Manifest = @{
    Path = "$ScriptDir\src\cloudmersiveConvert\cloudmersiveConvert.psd1"

    Author = 'Swagger Codegen Team'
    CompanyName = 'swagger.io'
    Description = 'cloudmersiveConvert - the PowerShell module for convertapi'

    RootModule = 'cloudmersiveConvert.psm1'
    Guid = '28771025-e21a-4a7c-a514-5fc1bad7f07b' # Has to be static, otherwise each new build will be considered different module

    PowerShellVersion = '3.0'

    RequiredAssemblies = Get-ChildItem "$BinPath\*.dll" | ForEach-Object {
        Join-Path $_.Directory.Name $_.Name
    }

    FunctionsToExport = $FunctionPath | Get-ChildItem -Filter *.ps1 | Get-FunctionsToExport

    VariablesToExport = @()
    AliasesToExport = @()
    CmdletsToExport = @()

    # Should we use prefix to prevent command name collisions?
    # https://www.sapien.com/blog/2016/02/15/use-prefixes-to-prevent-command-name-collision/
    #
    # Kirk Munro recommends against it:
    # https://www.sapien.com/blog/2016/02/15/use-prefixes-to-prevent-command-name-collision/#comment-20820
    #
    # If not, we'd need to generate functions name with prefix.
    #
    # DefaultCommandPrefix = 'PetStore'
}

New-ModuleManifest @Manifest
