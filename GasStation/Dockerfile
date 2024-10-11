FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["GasStation/GasStation.csproj", "GasStation/"]
RUN dotnet restore "GasStation/GasStation.csproj"
COPY . .
WORKDIR "/src/GasStation"
RUN dotnet build "GasStation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GasStation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GasStation.dll"]
