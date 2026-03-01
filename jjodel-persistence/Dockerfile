FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["jjodel-persistence/jjodel-persistence.csproj", "jjodel-persistence/"]
RUN dotnet restore "jjodel-persistence/jjodel-persistence.csproj"

COPY . .
WORKDIR /src/jjodel-persistence
RUN dotnet publish "jjodel-persistence.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "jjodel-persistence.dll"]
