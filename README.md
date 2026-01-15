🚕 Taxi Management System (EF Core)

A simple Taxi Management System built with C# and Entity Framework Core.
This project demonstrates core EF Core concepts including entities, relationships,
migrations, and database access using a code-first approach.

--------------------------------------------------

FEATURES

- Manage Taxis
- Manage Drivers
- Track Trips / Rides
- Entity relationships (one-to-many / many-to-one)
- Entity Framework Core (Code First)
- SQL database integration
- LINQ-based querying

--------------------------------------------------

TECH STACK

- .NET (Console / Application project)
- C#
- Entity Framework Core
- SQL Server / LocalDB
- LINQ

--------------------------------------------------

PROJECT STRUCTURE

Taxis/
 |
 |-- Models/        Entity classes (Taxi, Driver, Trip, etc.)
 |-- Data/          DbContext and database configuration
 |-- Migrations/    EF Core migrations
 |-- Program.cs     Application entry point
 |-- README.txt

--------------------------------------------------

CORE CONCEPTS DEMONSTRATED

- EF Core Code-First workflow
- DbContext and DbSet<T>
- Entity relationships
- Database migrations
- LINQ queries
- Grouping and aggregation logic
- Separation of concerns

--------------------------------------------------

GETTING STARTED

Prerequisites:
- .NET SDK
- SQL Server or LocalDB
- Visual Studio or VS Code

Clone the repository:
git clone https://github.com/ConnorM2020/Taxis.git
cd Taxis

Configure the database connection string in your DbContext or appsettings.

Apply migrations:
dotnet ef database update

Run the project:
dotnet run

--------------------------------------------------

FUTURE IMPROVEMENTS

- Add validation
- Add async EF Core queries
- Introduce DTOs
- Add unit tests
- Create a Web API or UI layer

--------------------------------------------------

AUTHOR

Connor Mallon
GitHub: https://github.com/ConnorM2020
