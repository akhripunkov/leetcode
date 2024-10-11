FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["FindtheIndexoftheFirstOccurrenceinString/FindtheIndexoftheFirstOccurrenceinString.csproj", "FindtheIndexoftheFirstOccurrenceinString/"]
RUN dotnet restore "FindtheIndexoftheFirstOccurrenceinString/FindtheIndexoftheFirstOccurrenceinString.csproj"
COPY . .
WORKDIR "/src/FindtheIndexoftheFirstOccurrenceinString"
RUN dotnet build "FindtheIndexoftheFirstOccurrenceinString.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FindtheIndexoftheFirstOccurrenceinString.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FindtheIndexoftheFirstOccurrenceinString.dll"]
