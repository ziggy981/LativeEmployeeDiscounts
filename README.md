# Lative Employee Discounts Calculator

![Solution Projects](https://user-images.githubusercontent.com/44898569/116045602-dc77ed00-a67a-11eb-82c6-ae1b2774c24e.PNG)

For this challenge, a simple Web Application (.Net Core 3.1 - Razor Pages) was developed to demonstrate the classes built to manage and work with the tables **SalesOrder** and **SalesOrderDetails** created by the scripts. Nothing too fancy, but to highlight general CRUD functionality using the classes.

Essentially, the application’s architecture was based using a simple implementation of **Clean Architecture** and **Domain-Driven Design (DDD)** principles. 

In a somewhat top-down fashion, the overall key principles, designs and frameworks used in this project are the following:
*	Clean Architecture
*	Domain-Driven Design (DDD)
*	Domain Services
*	Unit of Work
*	Generic Repository Design
*	Domain classes and abstractions (interfaces)
*	ASP.Net 5 Web Application – Razor Pages

### Application Architecture
The project’s layered architecture (high level) design is as follows:

![Arch](https://user-images.githubusercontent.com/44898569/116045633-e26dce00-a67a-11eb-8245-c0ba05b5c6c5.PNG)

In simple terms, the following layers function as follows:
*	**Web Application Layer**: The front-end application providing an interface for users to interact with the data.
*	**Shared Kernel**: Contains any cross-layer classes/functions to be used by all projects.
*	**Domain**: Contains business objects and logic abstractions (interfaces) to be used by all other layers.
*	**Application Services**: Called by the Web App and implements all business logic.
*	**Unit of Work**: Acts like a container that orchestrates between the different repositories.
*	**Generic Repository**: A construct acting as the repository (database) in code, with provider for Data Access layer.

As best practice, interfaces are implemented through generic Base Classes where possible to apply common functionality. Domain classes with particular functionality are extended through their individual interfaces and implementations.

#### Layer-Project Structure:

| Layer                      | Project                   |
| :-------------             |:-------------             |
| Web Application Layer      | Lative.Web                |
| Shared Kernel              | Lative.SharedKernel       |
| Domain                     | Lative.Domain             |
| Application Services       | Lative.Services           |
| Unit of Work               | Lative.Persistence        |
| Generic Repository         | Lative.Persistence        |





