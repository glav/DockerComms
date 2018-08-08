FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 52668

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY  DockerComms-Web.csproj DockerComms-Web/
RUN dotnet restore DockerComms-Web/DockerComms-Web.csproj
COPY  . ./DockerComms-Web
WORKDIR /src/DockerComms-Web
RUN dotnet build DockerComms-Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DockerComms-Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerComms-Web.dll"]
