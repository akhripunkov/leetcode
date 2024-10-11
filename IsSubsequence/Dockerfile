FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["IsSubsequence/IsSubsequence.csproj", "IsSubsequence/"]
RUN dotnet restore "IsSubsequence/IsSubsequence.csproj"
COPY . .
WORKDIR "/src/IsSubsequence"
RUN dotnet build "IsSubsequence.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IsSubsequence.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IsSubsequence.dll"]
