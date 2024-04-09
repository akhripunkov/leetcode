FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TimeNeededToBuyTickets/TimeNeededToBuyTickets.csproj", "TimeNeededToBuyTickets/"]
RUN dotnet restore "TimeNeededToBuyTickets/TimeNeededToBuyTickets.csproj"
COPY . .
WORKDIR "/src/TimeNeededToBuyTickets"
RUN dotnet build "TimeNeededToBuyTickets.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TimeNeededToBuyTickets.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TimeNeededToBuyTickets.dll"]
