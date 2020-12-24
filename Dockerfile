FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ["Museum/Museum.csproj", "Museum/"]
COPY ["MuseumData/MuseumData.csproj", "MuseumData/"]
COPY ["MuseumServices/MuseumServices.csproj", "MuseumServices/"]
RUN dotnet restore "Museum/Museum.csproj"

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Museum.dll", "--server.urls", "http://0.0.0.0:5000"]