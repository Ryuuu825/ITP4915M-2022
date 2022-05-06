# The Backend Server for [The Better Limited System](../TheBetterLimited-ManagementSystem)

## Introdution

```
```

## Features

- TODO

## Dependenies

- .Net 6
- Entity Framework Core CLI tools
- MySQL

## Get Started

### Create a file call secret.conf under ./etc

```
# The Mail Account

ServerURL="smtp.example.com"
Port="587"
Domain="@example.com"
Username="your user name"
DisplayedName="TheBetterLimited -- IT Team"
Password="your password"

# The API token
Token="ThisRequiredALongToken"

# MySQL connection string

ConnectionString="Data Source={db};Initial Catalog={};User Id={user};password={pw};ConnectionTimeout=5"
```

### create the database table

```
dotnet ef database update
```

### build the sysetm

```
dotnet build --configuration Release
```

### Or publish the system into a single executable with.Net 6 runtime contain

[see this page](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog)

```
dotnet publish -r {Runtime Identifier} /p:PublishSingleFile=true --configuration Relase -o {output dir}
```

## Overview
---

### File Structure

```
.
├── API                         <- The API handler
│   ├── Controller
│   ├── Filter
│   └── Services
├── AppLogic                    <- Application Logic
│   ├── Controllers
│   ├── Exceptions
│   └── Models
├── Data                        <- Data Access Logic
│   ├── Dto                     <- Entity / Model that are exposed to end user
│   ├── Entity
│   ├── EnumType
│   ├── Migrations
│   └── Repositories      
├── Helpers                     <- The Helpers Tools
│   ├── Entity
│   ├── File
│   ├── LogHelper
│   ├── Secure
│   └── Sql
├── Migrations
├── Properties
├── etc
```

### API documentation

[Click me](./API/API.md)