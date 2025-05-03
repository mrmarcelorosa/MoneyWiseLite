# MoneyWiseLite

MoneyWise Lite is a lightweight personal finance management system built with ASP.NET Core 9, React, and PostgreSQL. The project follows Clean Architecture principles and aims for clean, maintainable code.

## Features
- Expense and income tracking
- Categorization and filtering
- Monthly summaries and balance visualization
- Responsive design with React + TypeScript

## Tech Stack
- ASP.NET Core 9 (API)
- PostgreSQL (Database)
- React + TypeScript (Frontend)

## Architecture Overview

This project follows **Clean Architecture** and is organized in the following layers:

### 🧱 Core Layers

- **Domain**: Contains the core business entities and interfaces.
  - Includes a generic `BaseEntity` with common fields like `Id`, `CreatedAt`, and `LastUpdatedAt`.

- **Application**: Contains application logic and service interfaces.
  - Defines generic services (`IService<T>`) and implements them with base logic for CRUD operations.

- **Infrastructure**: Implements data access logic using Entity Framework Core.
  - Includes a generic repository pattern and database context configuration.
  - Automatically manages entity timestamps during `SaveChanges`.

- **API (Presentation)**: ASP.NET Core Web API layer.
  - Contains generic base controllers for reusable REST endpoints.
  - Uses Swagger for API documentation.

### 📦 Entity Structure

Each entity inherits from `BaseEntity`:

```csharp
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdatedAt { get; set; }
}
