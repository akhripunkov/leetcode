FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LengthOfLastWord/LengthOfLastWord.csproj", "LengthOfLastWord/"]
RUN dotnet restore "LengthOfLastWord/LengthOfLastWord.csproj"
COPY . .
WORKDIR "/src/LengthOfLastWord"
RUN dotnet build "LengthOfLastWord.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LengthOfLastWord.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LengthOfLastWord.dll"]
