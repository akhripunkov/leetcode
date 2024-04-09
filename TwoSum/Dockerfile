FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TwoSum/TwoSum.csproj", "TwoSum/"]
RUN dotnet restore "TwoSum/TwoSum.csproj"
COPY . .
WORKDIR "/src/TwoSum"
RUN dotnet build "TwoSum.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TwoSum.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TwoSum.dll"]
