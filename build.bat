dotnet restore --no-cache --force --verbosity normal
dotnet build --no-restore --no-incremental --verbosity normal --configuration Release
dotnet test --no-restore --no-build --verbosity normal --configuration Release --test-adapter-path:. --logger:nunit;LogFilePath=..\output\tests\results.xml PrimeService.Tests
dotnet pack --no-restore --no-build --verbosity normal --configuration Release --output ..\output\packages\