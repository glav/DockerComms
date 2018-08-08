FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 56150

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY DockerComms-api.csproj DockerComms-api/
RUN dotnet restore DockerComms-api/DockerComms-api.csproj
COPY . ./DockerComms-api
WORKDIR /src/DockerComms-api
RUN dotnet build DockerComms-api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DockerComms-api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerComms-api.dll"]
