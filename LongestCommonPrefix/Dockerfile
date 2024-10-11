FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["LongestCommonPrefix/LongestCommonPrefix.csproj", "LongestCommonPrefix/"]
RUN dotnet restore "LongestCommonPrefix/LongestCommonPrefix.csproj"
COPY . .
WORKDIR "/src/LongestCommonPrefix"
RUN dotnet build "LongestCommonPrefix.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LongestCommonPrefix.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LongestCommonPrefix.dll"]
