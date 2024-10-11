FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Majority Element/Majority Element.csproj", "Majority Element/"]
RUN dotnet restore "Majority Element/Majority Element.csproj"
COPY . .
WORKDIR "/src/Majority Element"
RUN dotnet build "Majority Element.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Majority Element.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Majority Element.dll"]
