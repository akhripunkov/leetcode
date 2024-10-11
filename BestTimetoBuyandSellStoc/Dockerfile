FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BestTimetoBuyandSellStoc/BestTimetoBuyandSellStoc.csproj", "BestTimetoBuyandSellStoc/"]
RUN dotnet restore "BestTimetoBuyandSellStoc/BestTimetoBuyandSellStoc.csproj"
COPY . .
WORKDIR "/src/BestTimetoBuyandSellStoc"
RUN dotnet build "BestTimetoBuyandSellStoc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BestTimetoBuyandSellStoc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BestTimetoBuyandSellStoc.dll"]
