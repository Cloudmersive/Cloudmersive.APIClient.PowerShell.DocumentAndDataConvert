function Invoke-ConvertTemplateApiConvertTemplateApplyHtmlTemplate {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [cloudmersiveConvert.Model.HtmlTemplateApplicationRequest]
        ${value}
    )

    Process {
        'Calling method: ConvertTemplateApi-ConvertTemplateApplyHtmlTemplate' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:ConvertTemplateApi.ConvertTemplateApplyHtmlTemplate(
            ${value}
        )
    }
}

