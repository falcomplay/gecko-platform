# 🦎 Gecko Platform

## Overview

Gecko Platform is a platform designed to simplify and secure the software delivery lifecycle.

It helps development and platform teams automate application delivery from source code to deployment across multiple environments.

---

## Why Gecko?

Modern applications require complex delivery chains:

* CI/CD pipelines
* Docker containerization
* Kubernetes deployments
* Security validation
* Environment management

Gecko aims to provide visibility, control and standardization across the entire application lifecycle.

---

## Architecture

Gecko is designed as a modular monolith following software engineering best practices.

Architecture principles:

* Monorepo
* Modular Monolith
* Clean Architecture

---

## Tech Stack

### Backend

* .NET 10
* MongoDB

### Frontend

* Angular 20

### Platform

* Docker
* Kubernetes
* Helm
* GitLab CI/CD

---

## Roadmap

Current status:

* Repository initialization completed
* Backend solution structure completed

Upcoming milestones:

* Backend foundation
* Frontend foundation
* Authentication and security
* CI/CD pipeline implementation
* Kubernetes deployment
* Helm charts
* DevSecOps integration

---

## Repository Structure

gecko-platform/

```
backend/
  Gecko.slnx
  src/
    Gecko.Api/
    Gecko.Application/
    Gecko.Domain/
    Gecko.Infrastructure/
  tests/
    Gecko.UnitTests/
    Gecko.IntegrationTests/

# Planned in upcoming roadmap steps
frontend/
deployment/
docs/
```
