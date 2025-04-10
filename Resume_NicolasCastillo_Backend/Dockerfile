# Etapa 1: build y publish
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore

COPY . ./
# Publicamos para linux-x64 y framework-dependent (no self-contained)
RUN dotnet publish -c Release -r linux-x64 -o /app/publish --no-self-contained

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Resume_NicolasCastillo_Backend.dll"]