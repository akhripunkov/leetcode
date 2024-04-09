FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FirstMissingPositive/FirstMissingPositive.csproj", "FirstMissingPositive/"]
RUN dotnet restore "FirstMissingPositive/FirstMissingPositive.csproj"
COPY . .
WORKDIR "/src/FirstMissingPositive"
RUN dotnet build "FirstMissingPositive.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FirstMissingPositive.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FirstMissingPositive.dll"]
