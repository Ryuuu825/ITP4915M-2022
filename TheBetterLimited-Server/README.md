# The Backend Server for [The Better Limited System](../TheBetterLimited-ManagementSystem)

## Introdution

```
```

## TODO
- [ ] optimize fetching data from database ( related to sql statement )

##  Dependencies
- Dotnet 6
- Entity Framework Core CLI tools
- Xampp MySQL or MySQL

## Get Started
1. Create the database that will be same as you specify in secret.conf
2. Build the system with
```
dotnet run 
```
3. Create three folder “./var” and “./var/log” and “./var/tmp” under build directory
4. Create a file call secret.conf under ./etc 
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

### File Structure (TODO: to update)

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
