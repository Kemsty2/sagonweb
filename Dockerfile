#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SagonWeb/SagonWeb.csproj", "SagonWeb/"]
COPY ["SangoBackendSDK/SangonBackendSDK.csproj", "SangoBackendSDK/"]
RUN dotnet restore "SagonWeb/SagonWeb.csproj"
RUN dotnet restore "SangoBackendSDK/SangoBackendSDK.csproj"
COPY . .
WORKDIR "/src/SagonWeb"
RUN dotnet build "SagonWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SagonWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "SagonWeb.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet SagonWeb.dll