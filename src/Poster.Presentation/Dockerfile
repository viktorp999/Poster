
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Poster.slnx", "./"]
COPY ["src/Poster.Presentation/Poster.Presentation.csproj", "src/Poster.Presentation/"]
COPY ["src/Poster.Application/Poster.Application.csproj", "src/Poster.Application/"]
COPY ["src/Poster.Domain/Poster.Domain.csproj", "src/Poster.Domain/"]
COPY ["src/Poster.Infrastructure/Poster.Infrastructure.csproj", "src/Poster.Infrastructure/"]
COPY ["tests/Poster.UnitTests/Poster.UnitTests.csproj", "tests/Poster.UnitTests/"]
RUN dotnet restore "Poster.slnx"
COPY . .
WORKDIR "/src/src/Poster.Presentation"
RUN dotnet build "./Poster.Presentation.csproj" -o /app/build

FROM build AS publish
RUN dotnet publish "./Poster.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Poster.Presentation.dll"]