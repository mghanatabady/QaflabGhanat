FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/QaflabGhanat.Web.Host/QaflabGhanat.Web.Host.csproj", "src/QaflabGhanat.Web.Host/"]
COPY ["src/QaflabGhanat.Web.Core/QaflabGhanat.Web.Core.csproj", "src/QaflabGhanat.Web.Core/"]
COPY ["src/QaflabGhanat.Application/QaflabGhanat.Application.csproj", "src/QaflabGhanat.Application/"]
COPY ["src/QaflabGhanat.Core/QaflabGhanat.Core.csproj", "src/QaflabGhanat.Core/"]
COPY ["src/QaflabGhanat.EntityFrameworkCore/QaflabGhanat.EntityFrameworkCore.csproj", "src/QaflabGhanat.EntityFrameworkCore/"]
WORKDIR "/src/src/QaflabGhanat.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/QaflabGhanat.Web.Host", "src/QaflabGhanat.Web.Host"]
COPY ["src/QaflabGhanat.Web.Core", "src/QaflabGhanat.Web.Core"]
COPY ["src/QaflabGhanat.Application", "src/QaflabGhanat.Application"]
COPY ["src/QaflabGhanat.Core", "src/QaflabGhanat.Core"]
COPY ["src/QaflabGhanat.EntityFrameworkCore", "src/QaflabGhanat.EntityFrameworkCore"]
WORKDIR "/src/src/QaflabGhanat.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "QaflabGhanat.Web.Host.dll"]
