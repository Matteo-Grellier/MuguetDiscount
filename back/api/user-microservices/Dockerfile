# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln /source
COPY *.csproj /source
RUN dotnet restore

FROM base as builder

# copy everything else and build app
COPY . /source
WORKDIR /source
RUN ["dotnet", "publish", "-c", "Release", "-o", "/build"]

FROM builder AS publisher

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0

WORKDIR /app
COPY --from=publisher /build .

CMD ["dotnet", "user-microservices.dll"]