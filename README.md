# IBAS SupportWebApp

## Formål

Dette projekt er en Blazor WebApp til IBAS Support.

Brugeren kan:
- Oprette en supporthenvendelse
- Vælge en kategori
- Gemme supporthenvendelsen i Azure Cosmos DB
- Se eksisterende supporthenvendelser

## Teknologier

- .NET / Blazor
- C#
- Azure Cosmos DB
- Azure CLI
- JetBrains Rider

## Azure Cosmos DB

Cosmos DB blev oprettet med Azure CLI.

Resource Group: IBasSupportRG

Cosmos DB Account: ibas-db-account-9383

Database: IBasSupportDB

Container: ibassupport

Partition key: /category

## Status

Følgende funktioner virker:

- Oprettelse af supporthenvendelser
- Validering af formularen
- Gemme data i Cosmos DB
- Hente data fra Cosmos DB
- Vise supporthenvendelser i en liste
- Navigation mellem siderne

## Næste skridt

Mulige forbedringer:

- Bedre design
- Mulighed for at redigere henvendelser
- Mulighed for at slette henvendelser
- Bedre fejlhåndtering