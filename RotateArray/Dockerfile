FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["RotateArray/RotateArray.csproj", "RotateArray/"]
RUN dotnet restore "RotateArray/RotateArray.csproj"
COPY . .
WORKDIR "/src/RotateArray"
RUN dotnet build "RotateArray.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RotateArray.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RotateArray.dll"]
