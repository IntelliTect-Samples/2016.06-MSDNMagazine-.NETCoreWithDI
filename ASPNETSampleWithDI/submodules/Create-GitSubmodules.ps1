
Function Add-Submodule {
    param(
        [Parameter(Position=1, Mandatory=$True, ValueFromPipeline=$True)][Url]$uri,
        $branch
    )
    $currentLocation = Get-Location
    try {
        git submodule --quiet add -b "(1.0.0-rc1)" https://github.com/aspnet/DependencyInjection.git
        $submoduleName = [IO.Path]::GetFileNameWithoutExtension( (([Uri]"$uri").AbsolutePath))
        Set-Location $submoduleName
        if($branch) {
            git checkout $branch  # Arg, needed because sometime -b doesn't work for some uninvestigated reason.
        }
    }
    finally {
        Set-Location $currentLocation
    }
}

#Warning: Refactored without testing. :)

$currentLocation = Get-Location
try {
    set-location $PSScriptRoot
    "DependencyInjection","Hosting" | %{
            Add-Submodule "https://github.com/aspnet/$_.git" "(1.0.0-rc1)"
    }
}
finally {
    Set-Location $currentLocation
}
