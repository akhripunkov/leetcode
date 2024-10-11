FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ValidPalindrome/ValidPalindrome.csproj", "ValidPalindrome/"]
RUN dotnet restore "ValidPalindrome/ValidPalindrome.csproj"
COPY . .
WORKDIR "/src/ValidPalindrome"
RUN dotnet build "ValidPalindrome.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ValidPalindrome.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ValidPalindrome.dll"]
