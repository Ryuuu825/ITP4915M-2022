# The Backend Server for [The Better Limited System](../TheBetterLimited-ManagementSystem) 

## Introdution
```
```

## Features
- TODO
## Dependenies
- .Net 6
- Entity Framework Core CLI tools

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
### update the database
```
dotnet ef database update
```

### build the sysetm
```
dotnet build --configuration Release
```

### build the system with .Net 6 runtime contain 
[see this page](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog)
```
dotnet build -r <RUNTIME_IDENTIFIER> -o {output directory}  --configuration Release
```

## API doucumentation
### TODO
