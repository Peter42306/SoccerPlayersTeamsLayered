# Template: Soccer, Players, Teams, Layered Architechture (UI, BLL, DAL)

ASP.NET Core MVC template application using a layered architecture with SQLite, showing:

- View football teams and players
- See which players and coaches belong to which team
- Filtering for players by position and team
- Use the seeded demo data

## Stack

- ASP.NET Core 8.0 MVC
- Entity Framework Core 8.0
- SQLite
- Bootstrap (for basic UI styling)
- Layered Architecture: UI / BLL / DAL

## Architecture

This project follows three-layered (three-projects) structure:

- Soccer - UI layer (ASP.NET Core MVC)
- Soccer.BLL - Business Logic Layer (services, interfaces)
- Soccer.DAL - Data Access Layer (DbContext, entities, migrations)

## Features

- One-to-many relationship: Team → Players
- Demo data seeded via OnModelCreating
- Dependency Injection configured via extension methods
- **Unit of Work pattern**: simplifies working with multiple repositories and ensures they share the same data context
- **AutoMapper**: maps one model to another, reducing code duplication and simplifying logic

## Screenshots

![Screenshot-2025-06-10-223615](https://github.com/user-attachments/assets/8676e467-d037-423b-ae38-423e9a939621)

![Screenshot-2025-06-10-223636](https://github.com/user-attachments/assets/a292217f-d954-4c12-aee8-877a88d5d1cd)

![Screenshot-2025-06-10-223655](https://github.com/user-attachments/assets/a4020730-ec65-49f7-a32d-0be0b8f99804)

![Screenshot-2025-06-10-223714](https://github.com/user-attachments/assets/c864a4e0-2875-49aa-8be4-0562048c9800)

![Screenshot-2025-06-10-223736](https://github.com/user-attachments/assets/e06be6e3-b71d-420d-9053-7b2292214324)

![Screenshot-2025-06-10-223748](https://github.com/user-attachments/assets/1b67b875-97c3-460c-b29b-bb5a05ef3ed1)
