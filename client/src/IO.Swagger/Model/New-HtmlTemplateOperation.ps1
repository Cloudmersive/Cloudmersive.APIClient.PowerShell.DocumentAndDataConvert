function New-HtmlTemplateOperation {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Action},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MatchAgsint},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ReplaceWith}
    )

    Process {
        'Creating object: cloudmersiveConvert.Model.HtmlTemplateOperation' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName cloudmersiveConvert.Model.HtmlTemplateOperation -ArgumentList @(
            ${Action},
            ${MatchAgsint},
            ${ReplaceWith}
        )
    }
}
