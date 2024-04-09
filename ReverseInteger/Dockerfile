FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ReverseInteger/ReverseInteger.csproj", "ReverseInteger/"]
RUN dotnet restore "ReverseInteger/ReverseInteger.csproj"
COPY . .
WORKDIR "/src/ReverseInteger"
RUN dotnet build "ReverseInteger.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReverseInteger.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReverseInteger.dll"]
