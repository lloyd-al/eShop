#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Features/Catalog/Catalog.Api/Catalog.Api.csproj", "src/Features/Catalog/Catalog.Api/"]
COPY ["src/Common.Infrastructure/Common.Infrastructure.csproj", "src/Common.Infrastructure/"]
COPY ["src/Common.Core/Common.Core.csproj", "src/Common.Core/"]
COPY ["src/Features/Catalog/Catalog.Application/Catalog.Application.csproj", "src/Features/Catalog/Catalog.Application/"]
COPY ["src/Features/Catalog/Catalog.Core/Catalog.Core.csproj", "src/Features/Catalog/Catalog.Core/"]
COPY ["src/Features/Catalog/Catalog.Infrastructure/Catalog.Infrastructure.csproj", "src/Features/Catalog/Catalog.Infrastructure/"]
RUN dotnet restore "src/Features/Catalog/Catalog.Api/Catalog.Api.csproj"
COPY . .
WORKDIR "/src/src/Features/Catalog/Catalog.Api"
RUN dotnet build "Catalog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.Catalog.Api.dll"]
