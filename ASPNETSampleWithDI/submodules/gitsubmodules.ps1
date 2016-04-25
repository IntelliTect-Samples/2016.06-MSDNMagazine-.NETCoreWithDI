$currentLocation = Get-Location
try {
set-location $PSScriptRoot
git submodule --quiet add -b "(1.0.0-rc1)" https://github.com/aspnet/DependencyInjection.git
git submodule --quiet add -b "(1.0.0-rc1)" https://github.com/aspnet/Hosting.git
}
finally {
    Set-Location $currentLocation
}dir