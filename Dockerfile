FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine3.12
WORKDIR /app

COPY . ./
RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "/app/out/SqliteAlpine.dll"]