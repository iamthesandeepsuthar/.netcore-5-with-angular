#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["prj.API/prj.API.csproj", "prj.API/"]
RUN dotnet restore "prj.API/prj.API.csproj"
COPY . .
WORKDIR "/src/prj.API"
RUN dotnet build "prj.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "prj.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "prj.API.dll"]