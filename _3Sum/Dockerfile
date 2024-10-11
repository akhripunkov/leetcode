FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["_3Sum/_3Sum.csproj", "_3Sum/"]
RUN dotnet restore "_3Sum/_3Sum.csproj"
COPY . .
WORKDIR "/src/_3Sum"
RUN dotnet build "_3Sum.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "_3Sum.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "_3Sum.dll"]
