FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/SoapServer/SoapServer.csproj", "src/SoapServer/"]
RUN dotnet restore "src/SoapServer/SoapServer.csproj"
COPY . .
WORKDIR "/src/src/SoapServer"
RUN dotnet build "SoapServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SoapServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SoapServer.dll"]
