#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/DigitalMarketing.Services/DigitalMarketing.Services.CMS/DigitalMarketing.Services.CMS.csproj", "src/DigitalMarketing.Services/DigitalMarketing.Services.CMS/"]
RUN dotnet restore "src/DigitalMarketing.Services/DigitalMarketing.Services.CMS/DigitalMarketing.Services.CMS.csproj"
COPY . .
WORKDIR "/src/src/DigitalMarketing.Services/DigitalMarketing.Services.CMS"
RUN dotnet build "DigitalMarketing.Services.CMS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigitalMarketing.Services.CMS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DigitalMarketing.Services.CMS.dll"]