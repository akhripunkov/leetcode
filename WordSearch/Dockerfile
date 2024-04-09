FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WordSearch/WordSearch.csproj", "WordSearch/"]
RUN dotnet restore "WordSearch/WordSearch.csproj"
COPY . .
WORKDIR "/src/WordSearch"
RUN dotnet build "WordSearch.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WordSearch.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WordSearch.dll"]
