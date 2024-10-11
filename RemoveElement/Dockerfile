FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["RemoveElement/RemoveElement.csproj", "RemoveElement/"]
RUN dotnet restore "RemoveElement/RemoveElement.csproj"
COPY . .
WORKDIR "/src/RemoveElement"
RUN dotnet build "RemoveElement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RemoveElement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RemoveElement.dll"]
