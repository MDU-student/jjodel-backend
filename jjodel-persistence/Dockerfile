FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /jjodel-backend-app

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -o out -c Debug

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /jjodel-backend-app
COPY --from=build /jjodel-backend-app/out .
ENTRYPOINT ["dotnet", "jjodel-persistence.dll"]