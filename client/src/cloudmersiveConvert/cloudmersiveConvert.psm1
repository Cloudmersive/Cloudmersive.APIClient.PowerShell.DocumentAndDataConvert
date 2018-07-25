#region Import functions

'API', 'Model', 'Private' | Get-ChildItem -Path {
    Join-Path $PSScriptRoot $_
} -Filter '*.ps1' | ForEach-Object {
    Write-Verbose "Importing file: $($_.BaseName)"
    try {
        . $_.FullName
    } catch {
        Write-Verbose "Can't import function!"
    }
}

#endregion


#region Initialize APIs

'Creating object: cloudmersiveConvert.Api.ConvertDataApi' | Write-Verbose
$Script:ConvertDataApi= New-Object -TypeName cloudmersiveConvert.Api.ConvertDataApi -ArgumentList @($null)

'Creating object: cloudmersiveConvert.Api.ConvertDocumentApi' | Write-Verbose
$Script:ConvertDocumentApi= New-Object -TypeName cloudmersiveConvert.Api.ConvertDocumentApi -ArgumentList @($null)

'Creating object: cloudmersiveConvert.Api.ConvertImageApi' | Write-Verbose
$Script:ConvertImageApi= New-Object -TypeName cloudmersiveConvert.Api.ConvertImageApi -ArgumentList @($null)

'Creating object: cloudmersiveConvert.Api.ConvertTemplateApi' | Write-Verbose
$Script:ConvertTemplateApi= New-Object -TypeName cloudmersiveConvert.Api.ConvertTemplateApi -ArgumentList @($null)

'Creating object: cloudmersiveConvert.Api.ConvertWebApi' | Write-Verbose
$Script:ConvertWebApi= New-Object -TypeName cloudmersiveConvert.Api.ConvertWebApi -ArgumentList @($null)


#endregion
