# BaseApp - Todo List Manager

![BaseApp Logo](path/to/logo.png) <!-- optional -->

## Overview

BaseApp is a Todo List Manager application built using a modern and maintainable architecture combining **Domain-Driven Design (DDD)** principles with Clean Architecture concepts influenced by **Steve “Ardalis” Smith** and **Jason Taylor**. This hybrid approach ensures clear separation of concerns, testability, and scalability.

---

## Architecture

### Layered Architecture

The solution is organized in four layers:

- **API Layer:** REST endpoints, Swagger, controllers.  
- **Application Layer:** Business logic, CQRS with MediatR, AutoMapper, Validation.  
- **Domain Layer:** Core entities, enums, domain rules.  
- **Infrastructure Layer:** Data access, repositories, external services.

This design combines:

- Ardalis’ Clean Architecture (pragmatic layered design)  
- Jason Taylor’s .NET Clean Architecture template  
- Domain-Driven Design (DDD) tactical patterns  
- Onion Architecture principles  

---

## Key Features

- **CQRS with MediatR** for command/query segregation  
- **AutoMapper** for entity-DTO mapping  
- **Repository Pattern** abstracts data persistence  
- **FluentValidation** integrated with MediatR pipeline behaviors  
- **Dependency Injection** structured per layer  
- **Swagger** API documentation

---

## Getting Started

### Prerequisites

- .NET 7 SDK or later  
- SQL Server or other supported database  
- Optional: Docker (if using containerization)

### Setup

```bash
git clone https://github.com/Farouk973/BaseApp.git
cd BaseApp
dotnet restore
dotnet build
dotnet run --project BaseApp.API
