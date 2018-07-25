function New-HtmlTemplateApplicationResponse {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Successful},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FinalHtml}
    )

    Process {
        'Creating object: cloudmersiveConvert.Model.HtmlTemplateApplicationResponse' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName cloudmersiveConvert.Model.HtmlTemplateApplicationResponse -ArgumentList @(
            ${Successful},
            ${FinalHtml}
        )
    }
}
