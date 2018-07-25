function Invoke-ConvertDocumentApiConvertDocumentAutodetectToPdf {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertDocumentApi-ConvertDocumentAutodetectToPdf' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertDocumentApi.ConvertDocumentAutodetectToPdf(
            ${inputFile}
        )
    }
}

function Invoke-ConvertDocumentApiConvertDocumentDocxToPdf {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertDocumentApi-ConvertDocumentDocxToPdf' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertDocumentApi.ConvertDocumentDocxToPdf(
            ${inputFile}
        )
    }
}

function Invoke-ConvertDocumentApiConvertDocumentPptxToPdf {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertDocumentApi-ConvertDocumentPptxToPdf' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertDocumentApi.ConvertDocumentPptxToPdf(
            ${inputFile}
        )
    }
}

function Invoke-ConvertDocumentApiConvertDocumentXlsxToCsv {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertDocumentApi-ConvertDocumentXlsxToCsv' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertDocumentApi.ConvertDocumentXlsxToCsv(
            ${inputFile}
        )
    }
}

function Invoke-ConvertDocumentApiConvertDocumentXlsxToPdf {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${inputFile}
    )

    Process {
        'Calling method: ConvertDocumentApi-ConvertDocumentXlsxToPdf' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertDocumentApi.ConvertDocumentXlsxToPdf(
            ${inputFile}
        )
    }
}

