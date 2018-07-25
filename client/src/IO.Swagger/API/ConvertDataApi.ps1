function Invoke-ConvertDataApiConvertDataCsvToJson {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertDataApi-ConvertDataCsvToJson' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertDataApi.ConvertDataCsvToJson(
            ${inputFile}
        )
    }
}

function Invoke-ConvertDataApiConvertDataXmlToJson {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertDataApi-ConvertDataXmlToJson' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertDataApi.ConvertDataXmlToJson(
            ${inputFile}
        )
    }
}

