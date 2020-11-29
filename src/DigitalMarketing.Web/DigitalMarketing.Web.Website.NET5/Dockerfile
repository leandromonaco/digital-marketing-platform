#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/DigitalMarketing.Web/DigitalMarketing.Web.Website.NET5/DigitalMarketing.Web.Website.NET5.csproj", "src/DigitalMarketing.Web/DigitalMarketing.Web.Website.NET5/"]
RUN dotnet restore "src/DigitalMarketing.Web/DigitalMarketing.Web.Website.NET5/DigitalMarketing.Web.Website.NET5.csproj"
COPY . .
WORKDIR "/src/src/DigitalMarketing.Web/DigitalMarketing.Web.Website.NET5"
RUN dotnet build "DigitalMarketing.Web.Website.NET5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigitalMarketing.Web.Website.NET5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DigitalMarketing.Web.Website.NET5.dll"]