function Invoke-ConvertWebApiConvertWebHtmlToPdf {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [cloudmersiveConvert.Model.HtmlToPdfRequest]
        ${input}
    )

    Process {
        'Calling method: ConvertWebApi-ConvertWebHtmlToPdf' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertWebApi.ConvertWebHtmlToPdf(
            ${input}
        )
    }
}

function Invoke-ConvertWebApiConvertWebUrlToPdf {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [cloudmersiveConvert.Model.ScreenshotRequest]
        ${input}
    )

    Process {
        'Calling method: ConvertWebApi-ConvertWebUrlToPdf' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertWebApi.ConvertWebUrlToPdf(
            ${input}
        )
    }
}

function Invoke-ConvertWebApiConvertWebUrlToScreenshot {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [cloudmersiveConvert.Model.ScreenshotRequest]
        ${input}
    )

    Process {
        'Calling method: ConvertWebApi-ConvertWebUrlToScreenshot' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertWebApi.ConvertWebUrlToScreenshot(
            ${input}
        )
    }
}

