function Invoke-ConvertImageApiConvertImageImageFormatConvert {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${format1},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${format2},
        [Parameter(Position = 2, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertImageApi-ConvertImageImageFormatConvert' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertImageApi.ConvertImageImageFormatConvert(
            ${format1},
            ${format2},
            ${inputFile}
        )
    }
}

