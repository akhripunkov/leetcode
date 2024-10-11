FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["JumpGame/JumpGame.csproj", "JumpGame/"]
RUN dotnet restore "JumpGame/JumpGame.csproj"
COPY . .
WORKDIR "/src/JumpGame"
RUN dotnet build "JumpGame.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JumpGame.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JumpGame.dll"]
