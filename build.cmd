
set version=%1
set key=%2

cd %~dp0
dotnet build magic.lambda.dates/magic.lambda.dates.csproj --configuration Release --source https://api.nuget.org/v3/index.json
dotnet nuget push magic.lambda.dates/bin/Release/magic.lambda.dates.%version%.nupkg -k %key% -s https://api.nuget.org/v3/index.json
