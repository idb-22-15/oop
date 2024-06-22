dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet new sln
dotnet sln app.sln add ./app.csproj

dotnet tool install --global dotnet-ef

dotnet ef migrations add init

dotnet ef database update

dotnet run