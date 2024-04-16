FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TrappingRainWater/TrappingRainWater.csproj", "TrappingRainWater/"]
RUN dotnet restore "TrappingRainWater/TrappingRainWater.csproj"
COPY . .
WORKDIR "/src/TrappingRainWater"
RUN dotnet build "TrappingRainWater.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TrappingRainWater.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrappingRainWater.dll"]
