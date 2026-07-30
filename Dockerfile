# Builds and runs the ASP.NET service on port 8087.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish src/DotnetService/DotnetService.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
ENV ASPNETCORE_HTTP_PORTS=8087
EXPOSE 8087
ENTRYPOINT ["dotnet", "DotnetService.dll"]
