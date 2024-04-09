FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["IsomorphicStrings/IsomorphicStrings.csproj", "IsomorphicStrings/"]
RUN dotnet restore "IsomorphicStrings/IsomorphicStrings.csproj"
COPY . .
WORKDIR "/src/IsomorphicStrings"
RUN dotnet build "IsomorphicStrings.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IsomorphicStrings.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IsomorphicStrings.dll"]
