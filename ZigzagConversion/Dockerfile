FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ZigzagConversion/ZigzagConversion.csproj", "ZigzagConversion/"]
RUN dotnet restore "ZigzagConversion/ZigzagConversion.csproj"
COPY . .
WORKDIR "/src/ZigzagConversion"
RUN dotnet build "ZigzagConversion.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZigzagConversion.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZigzagConversion.dll"]
