#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DigitalMarketing.Manager/DigitalMarketing.Web.Forms.csproj", "DigitalMarketing.Manager/"]
COPY ["DigitalMarketing.Model/DigitalMarketing.Core.csproj", "DigitalMarketing.Model/"]
RUN dotnet restore "DigitalMarketing.Manager/DigitalMarketing.Web.Forms.csproj"
COPY . .
WORKDIR "/src/DigitalMarketing.Manager"
RUN dotnet build "DigitalMarketing.Web.Forms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DigitalMarketing.Web.Forms.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DigitalMarketing.Web.Forms.dll"]