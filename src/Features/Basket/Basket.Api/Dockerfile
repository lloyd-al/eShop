#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Features/Basket/Basket.Api/Basket.Api.csproj", "src/Features/Basket/Basket.Api/"]
COPY ["src/Common.Infrastructure/Common.Infrastructure.csproj", "src/Common.Infrastructure/"]
COPY ["src/Common.Core/Common.Core.csproj", "src/Common.Core/"]
COPY ["src/Features/Basket/Basket.Application/Basket.Application.csproj", "src/Features/Basket/Basket.Application/"]
COPY ["src/Features/Basket/Basket.Infrastructure/Basket.Infrastructure.csproj", "src/Features/Basket/Basket.Infrastructure/"]
COPY ["src/Features/Basket/Basket.Core/Basket.Core.csproj", "src/Features/Basket/Basket.Core/"]
RUN dotnet restore "src/Features/Basket/Basket.Api/Basket.Api.csproj"
COPY . .
WORKDIR "/src/src/Features/Basket/Basket.Api"
RUN dotnet build "Basket.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Basket.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.Basket.Api.dll"]
