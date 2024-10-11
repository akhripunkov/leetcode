FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["H-Index/H-Index.csproj", "H-Index/"]
RUN dotnet restore "H-Index/H-Index.csproj"
COPY . .
WORKDIR "/src/H-Index"
RUN dotnet build "H-Index.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "H-Index.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "H-Index.dll"]
