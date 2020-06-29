#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Spike/Spike.csproj", "Spike/"]
COPY ["Spike.Domain/Spike.Domain.csproj", "Spike.Domain/"]
COPY ["Spike.Framework/Spike.Framework.csproj", "Spike.Framework/"]
RUN dotnet restore "Spike/Spike.csproj"
COPY . .
WORKDIR "/src/Spike"
RUN dotnet build "Spike.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Spike.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Spike.dll"]
