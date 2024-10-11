FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ContainerWithMostWater/ContainerWithMostWater.csproj", "ContainerWithMostWater/"]
RUN dotnet restore "ContainerWithMostWater/ContainerWithMostWater.csproj"
COPY . .
WORKDIR "/src/ContainerWithMostWater"
RUN dotnet build "ContainerWithMostWater.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContainerWithMostWater.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContainerWithMostWater.dll"]
