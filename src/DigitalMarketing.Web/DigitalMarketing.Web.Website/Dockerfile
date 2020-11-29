#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/DigitalMarketing.Web/DigitalMarketing.Web.Website/DigitalMarketing.Web.Website.csproj", "src/DigitalMarketing.Web/DigitalMarketing.Web.Website/"]
COPY ["src/DigitalMarketing.Core/DigitalMarketing.Core.csproj", "src/DigitalMarketing.Core/"]
RUN dotnet restore "src/DigitalMarketing.Web/DigitalMarketing.Web.Website/DigitalMarketing.Web.Website.csproj"
COPY . .
WORKDIR "/src/src/DigitalMarketing.Web/DigitalMarketing.Web.Website"
RUN dotnet build "DigitalMarketing.Web.Website.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigitalMarketing.Web.Website.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DigitalMarketing.Web.Website.dll"]
