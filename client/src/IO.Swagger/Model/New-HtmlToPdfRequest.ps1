function New-HtmlToPdfRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Html},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ExtraLoadingWait}
    )

    Process {
        'Creating object: cloudmersiveConvert.Model.HtmlToPdfRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName cloudmersiveConvert.Model.HtmlToPdfRequest -ArgumentList @(
            ${Html},
            ${ExtraLoadingWait}
        )
    }
}
