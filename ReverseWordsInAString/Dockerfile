FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ReverseWordsInAString/ReverseWordsInAString.csproj", "ReverseWordsInAString/"]
RUN dotnet restore "ReverseWordsInAString/ReverseWordsInAString.csproj"
COPY . .
WORKDIR "/src/ReverseWordsInAString"
RUN dotnet build "ReverseWordsInAString.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReverseWordsInAString.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReverseWordsInAString.dll"]
