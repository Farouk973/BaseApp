# 🚀 BaseApp - Todo List Manager

![BaseApp Banner](https://your-image-url.com/banner.png)

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)]()
[![License](https://img.shields.io/badge/license-MIT-blue.svg)]()
[![NuGet](https://img.shields.io/nuget/v/BaseApp.svg)]()

---

## ✨ Overview

Welcome to **BaseApp**, a clean, scalable, and maintainable **Todo List Manager** designed with modern architectural principles:

- **Domain-Driven Design (DDD)**
- **Clean Architecture** inspired by [Ardalis](https://ardalis.com/) & [Jason Taylor](https://jasontaylordev.com/)
- **Onion Architecture** for strict separation of concerns  
- **SOLID principles** for code quality and maintainability  

---

## 🏗️ Architecture

Our layered architecture is built to maximize flexibility, testability, and separation of concerns:

| Layer          | Responsibility                                  |
| -------------- | ----------------------------------------------- |
| **API**        | REST API endpoints, Swagger docs, Controllers  |
| **Application**| Business logic, CQRS (MediatR), AutoMapper, Validation |
| **Domain**     | Core entities, enums, business rules            |
| **Infrastructure** | Data access, repositories, external services |

This approach ensures that:

- Core business logic stays isolated from infrastructure and UI  
- Dependency flow is inward, preventing tight coupling  
- Your codebase is easy to maintain and evolve over time  

---

## 🚀 Features

- **CQRS + MediatR:** Clear separation between commands and queries  
- **AutoMapper:** Effortless mapping between domain models and DTOs  
- **Repository Pattern:** Abstract data access to support multiple data stores  
- **FluentValidation:** Declarative validation integrated seamlessly via MediatR pipeline  
- **Dependency Injection:** Organized per-layer registration keeping Program.cs clean  
- **Swagger UI:** Interactive API documentation out-of-the-box  

---

## ⚙️ Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download) or higher  
- SQL Server or preferred supported database  
- (Optional) Docker for containerized deployment  

### Setup

```bash
git clone https://github.com/Farouk973/BaseApp.git
cd BaseApp
dotnet restore
dotnet build
dotnet run --project BaseApp.API
