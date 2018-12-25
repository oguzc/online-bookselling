FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY OnlineBookselling/OnlineBookselling.csproj OnlineBookselling/
RUN dotnet restore OnlineBookselling/OnlineBookselling.csproj
COPY . .
WORKDIR /src/OnlineBookselling
RUN dotnet build OnlineBookselling.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish OnlineBookselling.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OnlineBookselling.dll"]
