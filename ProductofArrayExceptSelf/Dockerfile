FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ProductofArrayExceptSelf/ProductofArrayExceptSelf.csproj", "ProductofArrayExceptSelf/"]
RUN dotnet restore "ProductofArrayExceptSelf/ProductofArrayExceptSelf.csproj"
COPY . .
WORKDIR "/src/ProductofArrayExceptSelf"
RUN dotnet build "ProductofArrayExceptSelf.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProductofArrayExceptSelf.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProductofArrayExceptSelf.dll"]
