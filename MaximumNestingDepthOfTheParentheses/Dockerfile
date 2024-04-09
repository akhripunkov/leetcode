FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MaximumNestingDepthOfTheParentheses/MaximumNestingDepthOfTheParentheses.csproj", "MaximumNestingDepthOfTheParentheses/"]
RUN dotnet restore "MaximumNestingDepthOfTheParentheses/MaximumNestingDepthOfTheParentheses.csproj"
COPY . .
WORKDIR "/src/MaximumNestingDepthOfTheParentheses"
RUN dotnet build "MaximumNestingDepthOfTheParentheses.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MaximumNestingDepthOfTheParentheses.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MaximumNestingDepthOfTheParentheses.dll"]
