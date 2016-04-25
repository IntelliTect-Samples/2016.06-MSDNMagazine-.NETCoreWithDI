$currentLocation = Get-Location
try {
set-location $PSScriptRoot
git submodule --quiet add -b "(1.0.0-rc1)" https://github.com/aspnet/DependencyInjection.git
Set-Location DependencyInjection
git checkout "1.0.0-rc1"
Set-Location ..
git submodule --quiet add -b "(1.0.0-rc1)" https://github.com/aspnet/Hosting.git
Set-Location Hosting
git checkout "1.0.0-rc1"
}
finally {
    Set-Location $currentLocation
}