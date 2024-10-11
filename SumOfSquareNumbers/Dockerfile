FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SumOfSquareNumbers/SumOfSquareNumbers.csproj", "SumOfSquareNumbers/"]
RUN dotnet restore "SumOfSquareNumbers/SumOfSquareNumbers.csproj"
COPY . .
WORKDIR "/src/SumOfSquareNumbers"
RUN dotnet build "SumOfSquareNumbers.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SumOfSquareNumbers.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SumOfSquareNumbers.dll"]
