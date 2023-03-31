Write-Host "About to Create the directory" -ForegroundColor Green

mkdir TestApi
cd TestApi

Write-Host "About to create the solution and projects" -ForegroundColor Green
dotnet new sln
dotnet new webapi -n API

Write-Host "Adding projects to the solution" -ForegroundColor Green
dotnet sln add API/API.csproj

Write-Host "Executing dotnet restore" -ForegroundColor Green
dotnet restore

Write-Host "Finished!" -ForegroundColor Green
