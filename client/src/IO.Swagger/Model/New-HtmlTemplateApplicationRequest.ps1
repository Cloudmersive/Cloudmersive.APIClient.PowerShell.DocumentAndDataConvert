function New-HtmlTemplateApplicationRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${HtmlTemplate},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${HtmlTemplateUrl},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[cloudmersiveConvert.Model.HtmlTemplateOperation[]]]
        ${Operations}
    )

    Process {
        'Creating object: cloudmersiveConvert.Model.HtmlTemplateApplicationRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName cloudmersiveConvert.Model.HtmlTemplateApplicationRequest -ArgumentList @(
            ${HtmlTemplate},
            ${HtmlTemplateUrl},
            ${Operations}
        )
    }
}
