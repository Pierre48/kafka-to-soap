FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/EventSimulator/EventSimulator.csproj", "src/EventSimulator/"]
RUN dotnet restore "src/EventSimulator/EventSimulator.csproj"
COPY . .
WORKDIR "/src/src/EventSimulator"
RUN dotnet build "EventSimulator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EventSimulator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EventSimulator.dll"]
