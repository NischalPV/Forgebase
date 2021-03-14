# Forgebase Identity

This project serves as Identity provider for the solution. All the authorizations and authentications are handeled by this service.

## Configuration

`appsettings.json` file has all the configuration required by the project.

### Database Operations

Service has 3 DbContexts i.e.
1. `ApplicationDbContext` - which stores user information.
2. `ConfigurationDbContext` - which handles IdentityServer4 clients information.
3. `PersistedGrantDbContext` - which stores information about device codes and sessions

> Seed data is present in `Data/MasterData.cs` file.
> IdentityServer4 configuration data is in the file `Configuration/IdentityServer.cs`.

* To create new migrations use following cli command:

`dotnet ef migrations add {migration_name} -o Data/Migrations/{folder_name} --context {DbContext_name}`

* To update database with created migrations use following cli command:

`dotnet ef database update --context {DbContext_name}`