update: Clean
	dotnet ef migrations add CREATEALLTABLE -o ./Data/EFMigrations
	dotnet ef database update

updaten:
	dotnet ef migrations add $(NAME) -o ./Data/EFMigrations
	dotnet ef database update

Clean:
	dotnet ef database drop
	dotnet ef migrations remove  -f
