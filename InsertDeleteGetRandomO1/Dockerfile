FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["InsertDeleteGetRandomO1/InsertDeleteGetRandomO1.csproj", "InsertDeleteGetRandomO1/"]
RUN dotnet restore "InsertDeleteGetRandomO1/InsertDeleteGetRandomO1.csproj"
COPY . .
WORKDIR "/src/InsertDeleteGetRandomO1"
RUN dotnet build "InsertDeleteGetRandomO1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InsertDeleteGetRandomO1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InsertDeleteGetRandomO1.dll"]
