FROM mcr.microsoft.com/dotnet/sdk:5.0 as base

WORKDIR /workspace
COPY aspnet_api_repo .
COPY aspnet_api_store .
COPY aspnet_mvc .
RUN dotnet build -t aspnet_mvc .
RUN dotnet publish -c Release -o out CardCram.Client/CardCram.Client.csproj

FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /publish
COPY --from=base workspace/out .
CMD ["dotnet", "CardCram.Client.dll"]