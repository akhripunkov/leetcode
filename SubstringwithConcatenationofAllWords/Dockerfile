FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SubstringwithConcatenationofAllWords/SubstringwithConcatenationofAllWords.csproj", "SubstringwithConcatenationofAllWords/"]
RUN dotnet restore "SubstringwithConcatenationofAllWords/SubstringwithConcatenationofAllWords.csproj"
COPY . .
WORKDIR "/src/SubstringwithConcatenationofAllWords"
RUN dotnet build "SubstringwithConcatenationofAllWords.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SubstringwithConcatenationofAllWords.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SubstringwithConcatenationofAllWords.dll"]
