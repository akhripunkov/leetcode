FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MakeTheStringGreat/MakeTheStringGreat.csproj", "MakeTheStringGreat/"]
RUN dotnet restore "MakeTheStringGreat/MakeTheStringGreat.csproj"
COPY . .
WORKDIR "/src/MakeTheStringGreat"
RUN dotnet build "MakeTheStringGreat.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MakeTheStringGreat.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MakeTheStringGreat.dll"]
