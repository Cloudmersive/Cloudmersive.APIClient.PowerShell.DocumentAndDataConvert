function New-ScreenshotRequest {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Url},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${ExtraLoadingWait}
    )

    Process {
        'Creating object: cloudmersiveConvert.Model.ScreenshotRequest' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName cloudmersiveConvert.Model.ScreenshotRequest -ArgumentList @(
            ${Url},
            ${ExtraLoadingWait}
        )
    }
}
