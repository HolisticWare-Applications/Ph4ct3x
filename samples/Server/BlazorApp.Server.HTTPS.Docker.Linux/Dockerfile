FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["BlazorApp.Server.HTTPS.Docker.Linux/BlazorApp.Server.HTTPS.Docker.Linux.csproj", "BlazorApp.Server.HTTPS.Docker.Linux/"]
RUN dotnet restore "BlazorApp.Server.HTTPS.Docker.Linux/BlazorApp.Server.HTTPS.Docker.Linux.csproj"
COPY . .
WORKDIR "/src/BlazorApp.Server.HTTPS.Docker.Linux"
RUN dotnet build "BlazorApp.Server.HTTPS.Docker.Linux.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorApp.Server.HTTPS.Docker.Linux.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorApp.Server.HTTPS.Docker.Linux.dll"]