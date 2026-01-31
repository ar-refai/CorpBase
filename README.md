CorpBase

CorpBase is a .NET 8 WinForms application designed as a learning-grade but production-style project to demonstrate how desktop applications should be structured when following enterprise software engineering principles.

The project focuses on ADO.NET, N-Tier architecture, SOLID principles, and Dependency Injection, with a clear separation between UI, Business Logic, and Data Access layers.

🎯 Project Goals

Practice ADO.NET in both:

Connected Mode (SqlConnection, SqlCommand, SqlDataReader)

Disconnected Mode (SqlDataAdapter, DataTable)

Apply N-Tier Architecture correctly

Use Repository Pattern

Apply SOLID principles

Implement Dependency Injection in WinForms

Prepare the architecture for a future migration to Entity Framework Core

Follow professional Git & GitHub workflows

🧱 Architecture Overview
CorpBase (Solution)
│
├── CorpBase.Common
│   ├── Entities / DTOs
│   └── Interfaces (Repository Contracts)
│
├── CorpBase.Data
│   ├── ADO.NET Data Access
│   ├── Repositories
│   └── SQL Connection Management
│
├── CorpBase.Business
│   ├── Business Rules
│   ├── Validation Logic
│   └── Application Services
│
└── CorpBase.WinUI
    ├── Windows Forms (UI)
    └── Dependency Injection Setup

🗄️ Database

SQL Server

Relational design with:

Departments (Parent)

Employees (Child)

Enforced Foreign Key relationships

⚙️ Technologies Used

.NET 8 (Windows)

WinForms

ADO.NET

SQL Server

Dependency Injection (Microsoft.Extensions.DependencyInjection)

Git & GitHub

✨ Features Implemented

CRUD operations for Employees and Departments

Search functionality

Active / Inactive employee status

DataGridView data binding

Input validation in the Business layer

Safe SQL operations using parameters

Confirmation dialogs for destructive actions

🧠 Key Learning Concepts

Difference between Connected vs Disconnected data access

Why Business Rules should not live in the UI

How Dependency Injection improves testability and maintainability

Why repositories should be data-only

How architecture enables future scalability

🚀 Future Improvements

Entity Framework Core implementation

Transaction handling

Unit testing

Logging

Vertical Slice architecture comparison

📌 Author

Built as a deliberate learning project focused on mastering foundational .NET backend and desktop architecture concepts.