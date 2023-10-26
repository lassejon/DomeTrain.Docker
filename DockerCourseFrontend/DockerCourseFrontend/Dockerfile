#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DockerCourseFrontend/DockerCourseFrontend.csproj", "DockerCourseFrontend/"]
RUN dotnet restore "DockerCourseFrontend/DockerCourseFrontend.csproj"
COPY . .
WORKDIR "/src/DockerCourseFrontend"

RUN dotnet publish "DockerCourseFrontend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM nginx:1.25.3-alpine
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html