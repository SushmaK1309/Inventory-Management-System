# Tech Inventory Management System (TIMS)

## Overview

The Tech Inventory Management System (TIMS) is a web-based application developed using ASP.NET Core Web API. It helps organizations manage IT products, categories, and inventory efficiently by reducing manual work and improving inventory tracking.

This project follows a layered architecture using the Repository Pattern and Dependency Injection, making it easy to maintain and extend.

---

## Features

### Category Management
- Add Category
- Update Category
- Delete Category
- View Categories

### Product Management
- Add Product
- Update Product
- Delete Product
- Search Products

### Inventory Management
- Stock In
- Stock Out
- View Inventory Report

---

## Technology Stack

### Backend
- ASP.NET Core Web API (.NET 8)
- C#
- Entity Framework Core (Phase 2)
- SQL Server (Phase 2)

### Frontend
- HTML
- CSS
- Bootstrap
- JavaScript

### Tools
- Visual Studio 2022
- Visual Studio Code
- Swagger (API Testing)
- Git & GitHub

---

## Project Architecture

```
Client
   │
   ▼
Frontend (HTML, CSS, Bootstrap, JavaScript)
   │
   ▼
ASP.NET Core Web API
   │
   ▼
Controllers
   │
   ▼
Services
   │
   ▼
Repositories
   │
   ▼
Data Source
(In-Memory Repository / SQL Server)
```

---

## Project Structure

```
Tech_Inventory_Management_System
│
├── Controllers
├── Models
├── DTOs
├── Interfaces
│   ├── Repositories
│   └── Services
├── Repositories
├── Services
├── Middleware
├── Helpers
├── Data
├── Properties
├── appsettings.json
├── Program.cs
└── README.md
```

---

## Current Implementation (Phase 1)

- Project Setup
- Layered Architecture
- Category Module
- In-Memory Repository
- Repository Pattern
- Dependency Injection
- Swagger Integration

---

## Future Enhancements (Phase 2)

- SQL Server Integration
- Entity Framework Core
- Product Module
- Inventory Module
- JWT Authentication
- Role-Based Authorization
- User Management
- Dashboard
- Barcode Support
- Product Image Upload
- Export to Excel/PDF
- Logging & Caching

---

## How to Run the Project

1. Clone the repository.

```
git clone <repository-url>
```

2. Open the solution in Visual Studio 2022.

3. Build the project.

4. Run the application.

5. Open Swagger.

```
https://localhost:<port>/swagger
```

---

## Design Patterns Used

- Repository Pattern
- Dependency Injection
- Layered Architecture
- DTO Pattern

---

## Project Status

**Current Status:** Phase 1 – Category Module using In-Memory Repository.

SQL Server integration and additional modules will be implemented in the next phase.

---

## Author

Developed by **Sushma K** as part of the ASP.NET Core Web API learning project.
