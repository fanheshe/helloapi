# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /source

# copy everything else and build app
COPY . ./BMW.Hold.Api/
WORKDIR /source/BMW.Hold.Api
RUN dotnet publish -c release -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "helloapi.dll"]
