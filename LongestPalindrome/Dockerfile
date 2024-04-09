FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LongestPalindrome/LongestPalindrome.csproj", "LongestPalindrome/"]
RUN dotnet restore "LongestPalindrome/LongestPalindrome.csproj"
COPY . .
WORKDIR "/src/LongestPalindrome"
RUN dotnet build "LongestPalindrome.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LongestPalindrome.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LongestPalindrome.dll"]
