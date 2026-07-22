# 🦎 Gecko Platform

## Overview

Gecko Platform is a platform designed to simplify and secure the software delivery lifecycle.

It enables development and platform teams to automate application delivery from source code to deployment across multiple environments while maintaining visibility and control.

---

## Why Gecko?

Modern software delivery requires much more than simply building an application.

Gecko is a learning platform built to explore the complete software delivery lifecycle:

- CI/CD Pipelines
- Docker containerization
- Kubernetes deployments
- Environment management
- DevSecOps practices
- Monitoring deployment history

---

## Architecture

Gecko follows a **Modular Monolith** architecture based on **Clean Architecture** principles.

### Architectural Principles

- Monorepo
- Modular Monolith
- Clean Architecture
- Dependency Injection
- Repository Pattern
- CQRS (when relevant)
- SOLID
- Clean Code

---

## Tech Stack

### Backend

- .NET 10
- ASP.NET Core Web API
- MongoDB

### Frontend

- Angular 20

### Platform

- Docker
- Docker Compose
- Kubernetes
- Helm
- GitLab CI/CD

### Quality

- xUnit
- SonarQube

---

## Project Roadmap

### EPIC 1 — Project Foundation

#### US-001 — Repository Initialization

- [x] Git repository
- [x] GitHub repository
- [x] GitLab repository
- [x] README
- [x] MIT License
- [x] .editorconfig
- [x] Git conventions

#### US-002 — Project Architecture

- [x] Monorepo structure
- [x] Naming conventions
- [x] Folder organization
- [x] Modular Monolith architecture
- [x] Clean Architecture definition

#### US-003 — Backend Design

- [x] Project responsibilities
- [x] Dependency rules
- [x] Clean Architecture validation
- [x] Domain modeling preparation

#### US-004 — Backend Foundation

- [x] .NET solution
- [x] Gecko.Api
- [x] Gecko.Application
- [x] Gecko.Domain
- [x] Gecko.Infrastructure
- [x] Gecko.UnitTests
- [x] Gecko.IntegrationTests
- [x] Project references

#### US-005 — Domain Foundation

- [ ] Create first domain entities
- [ ] Model business objects
- [ ] Prepare domain structure

---

### Upcoming EPICs

- Authentication (JWT)
- MongoDB Integration
- REST API
- Angular Frontend
- Docker
- Docker Compose
- GitLab CI/CD
- SonarQube
- Kubernetes
- Helm
- DevSecOps
- Observability
- Production deployment

---

## Repository Structure

```text
gecko-platform/

backend/
│
├── Gecko.slnx
│
├── src/
│   ├── Gecko.Api/
│   ├── Gecko.Application/
│   ├── Gecko.Domain/
│   └── Gecko.Infrastructure/
│
└── tests/
    ├── Gecko.UnitTests/
    └── Gecko.IntegrationTests/

frontend/
deployment/
docs/
```

---

## Project Status

🚧 Currently under active development.

Current milestone:

**EPIC 1 — Foundation**

---

## License

MIT License