# Microservices-Based Application

Welcome to the MicroserviceEconomyProject repository. This project is a comprehensive implementation of microservices architecture using modern technologies and best practices. It encapsulates the journey from setting up the development environment to integrating asynchronous communication between services and frontend interaction.

This website was built with:

+ ASP.NET Core and C# for cross-platform server-side code
+ Docker for services containerization
+ MongoDB for database storage
+ RabbitMQ and MassTransit for message-based asynchronous communication
+ React for client-side rendering and Bootstrap for layout and styling

## Table of Contents

+ [Features](###-features)
+ [Architecture Overview](###architecture-overview)
+ [Tech Stack](###-tech-stack)
+ [Prerequisites](###-prerequisites)
+ [Inter Service Communication](###-inter-service-communication)
+ [Frontend Integration](###-frontend-integration)

 ### Features

+ **Modular Microservices**: Independent services for scalability and maintainability.
+ **RESTful APIs**: Efficient and standardized communication.
+ **Database Integration**: MongoDB for data persistence.
+ **Synchronous Communication**: Implemented via IHttpClientFactory with resilience patterns.
+ **Asynchronous Communication**: Leveraging RabbitMQ and MassTransit for message-based interactions.
+ **Dependency Injection & Configuration**: Ensuring modularity and testability.
+ **Dockerized Environment**: Containerization of services for consistent deployment.
+ **Frontend Integration**: Seamless interaction between frontend and microservices with CORS enabled.

### Architecture Overview

The application consists of multiple microservices, each responsible for a specific domain. The services communicate synchronously and asynchronously to ensure data consistency and reliability. The frontend interacts with these services through exposed APIs.

### Tech Stack

+ **Backend:**
  - C# (.NET Core)
  - MongoDB
  - RabbitMQ
  - MassTransit
  - Docker & Docker Compose
  - Polly (Resilience and transient-fault handling)

+ **Frontend:**
  - Node.js

+ **Tools:**
  - Visual Studio Code
  - Postman

### Prerequisites

+ .NET SDK
+ Node.js
+ Docker
+ Visual Studio Code

### Inter Service Communication

+ **Synchronous**: Implemented using IHttpClientFactory with resilience patterns like timeouts, retries with exponential backoff, and circuit breakers using Polly.

+ **Asynchronous**: Leveraging RabbitMQ and MassTransit for publishing and consuming messages, ensuring eventual consistency and decoupled communication.

### Frontend Integration

The frontend, built with Node.js, interacts with the backend services through exposed RESTful APIs. CORS is configured to allow seamless communication between the frontend and backend.

This website was built with:

ASP.NET Core and C# for cross-platform server-side code
Docker for services containerization
MongoDB for database storage
RabbitMQ and MassTransit for message-based asynchronous communication
React for client-side rendering and Bootstrap for layout and styling
