FROM mcr.microsoft.com/dotnet/sdk:7.0 AS c
WORKDIR /app   

    
COPY ["DockerAPI/DockerAPI.csproj", "DockerAPI/"]
COPY ["Application/Application.csproj", "Application/"]
#others reference if necesary



RUN dotnet restore "DockerAPI/DockerAPI.csproj" 

COPY . .
WORKDIR "/app/DockerAPI"
RUN dotnet build "DockerAPI.csproj" -c Release -o /app/build

from c as publish
RUN dotnet publish "DockerAPI.csproj" -c Release -o /app/publish
 

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app 
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerAPI.dll"]