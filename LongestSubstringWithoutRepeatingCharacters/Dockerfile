FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LongestSubstringWithoutRepeatingCharacters/LongestSubstringWithoutRepeatingCharacters.csproj", "LongestSubstringWithoutRepeatingCharacters/"]
RUN dotnet restore "LongestSubstringWithoutRepeatingCharacters/LongestSubstringWithoutRepeatingCharacters.csproj"
COPY . .
WORKDIR "/src/LongestSubstringWithoutRepeatingCharacters"
RUN dotnet build "LongestSubstringWithoutRepeatingCharacters.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LongestSubstringWithoutRepeatingCharacters.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LongestSubstringWithoutRepeatingCharacters.dll"]
