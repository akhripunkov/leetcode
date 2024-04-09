FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MedianOfTwoSortedArrays/MedianOfTwoSortedArrays.csproj", "MedianOfTwoSortedArrays/"]
RUN dotnet restore "MedianOfTwoSortedArrays/MedianOfTwoSortedArrays.csproj"
COPY . .
WORKDIR "/src/MedianOfTwoSortedArrays"
RUN dotnet build "MedianOfTwoSortedArrays.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MedianOfTwoSortedArrays.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MedianOfTwoSortedArrays.dll"]
