# Builds and runs the ASP.NET service. The published DLL is DotnetService.dll
# (from src/DotnetService/DotnetService.csproj); ASP.NET Core listens on 8080.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish src/DotnetService/DotnetService.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 8080
ENTRYPOINT ["dotnet", "DotnetService.dll"]
