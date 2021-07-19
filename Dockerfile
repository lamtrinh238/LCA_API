FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

WORKDIR /app
COPY lca.api/*.csproj ./
RUN dotnet restore


COPY . .
WORKDIR /app/lca.api
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 

WORKDIR /app
COPY --from=build-env /app/lca.api/out .

# ENTRYPOINT [ "dotnet", "LCA.API.dll" ]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet LCA.API.dll