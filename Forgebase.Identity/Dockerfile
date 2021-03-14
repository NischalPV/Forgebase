#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY Forgebase.Identity/Forgebase.Identity.csproj Forgebase.Identity/
RUN dotnet restore "Forgebase.Identity/Forgebase.Identity.csproj"
COPY . .
WORKDIR "/src/Forgebase.Identity"
RUN dotnet build "Forgebase.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Forgebase.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Forgebase.Identity.dll"]
