FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["lab10erick.sln", "./"]
COPY ["lab10erick/lab10erick.csproj", "lab10erick/"]
COPY ["lab10erick.Infrastructure/lab10erick.Infrastructure.csproj", "lab10erick.Infrastructure/"]
COPY ["laberick10.Domain/laberick10.Domain.csproj", "laberick10.Domain/"]

RUN dotnet restore "lab10erick.sln"

COPY . .

RUN dotnet publish "lab10erick/lab10erick.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "lab10erick.dll"]