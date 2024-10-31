FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MinimumSizeSubarraySum/MinimumSizeSubarraySum.csproj", "MinimumSizeSubarraySum/"]
RUN dotnet restore "MinimumSizeSubarraySum/MinimumSizeSubarraySum.csproj"
COPY . .
WORKDIR "/src/MinimumSizeSubarraySum"
RUN dotnet build "MinimumSizeSubarraySum.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinimumSizeSubarraySum.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinimumSizeSubarraySum.dll"]
