# Lative Employee Discounts Calculator

![SalesApp Projects](https://user-images.githubusercontent.com/44898569/114894953-bd29c600-9e17-11eb-8e43-871277f9788b.png)

For this challenge, a simple Web Application (.Net Core 3.1 - Razor Pages) was developed to demonstrate the classes built to manage and work with the tables **SalesOrder** and **SalesOrderDetails** created by the scripts. Nothing too fancy, but to highlight general CRUD functionality using the classes.

Essentially, the application’s architecture was based using a simple implementation of **Clean Architecture** and **Domain-Driven Design (DDD)** principles. 

In a somewhat top-down fashion, the overall key principles, designs and frameworks used in this project are the following:
*	Clean Architecture
*	Domain-Driven Design (DDD)
*	Domain Services
*	Unit of Work
*	Generic Repository Design
*	Entity Framework Core (Code-First)
*	Domain classes and abstractions (interfaces)
*	ASP.Net 3.1 Web Application – Razor Pages
*	Dependency Injection (AutoMapper, ILogger, IDomainServices…etc)



### Application Architecture
The project’s layered architecture (high level) design is as follows:

![Arch Diagram](https://user-images.githubusercontent.com/44898569/114894896-b1d69a80-9e17-11eb-9355-cd78606518eb.JPG)

In simple terms, the following layers function as follows:
*	**Web Application Layer**: The front-end application providing an interface for users to interact with the data.
*	**Shared Kernel**: Contains any cross-layer classes/functions to be used by all projects.
*	**Domain**: Contains business objects and logic abstractions (interfaces) to be used by all other layers.
*	**Application Services**: Called by the Web App and implements all business logic.
*	**Unit of Work**: Acts like a container that orchestrates between the different repositories.
*	**Generic Repository**: A construct acting as the repository (database) in code, with provider for Data Access layer.
*	**Entity Framework**: The used Data Access layer in this project. Essentially communicates directly with the DB.

As best practice, interfaces are implemented through generic Base Classes where possible (ex: ServiceBase, RepositoryBase) to apply common functionality. Domain classes with particular functionality are extended through their individual interfaces and implementations.

#### Layer-Project Structure:

| Layer                    | Project                         |
| :-------------           |:-------------                   |
| Web Application Layer    | Terracor.SalesApp.Web           |
| Shared Kernel            | Terracor.SalesApp.SharedKernel  |
| Domain                   | Terracor.SalesApp.Domain        |
| Application Services     | Terracor.SalesApp.Services      |
| Unit of Work             | Terracor.SalesApp.Persistence   |
| Generic Repository       | Terracor.SalesApp.Persistence   |
| Entity Framework         | Terracor.SalesApp.Persistence   |

#### Setup
Simply change the **DefaultConnection** in the _appsettings.json_ file to point to your database.

If your database is empty, the application will automatically populate it with dummy data once you run it.

##### Database Scripts
```sql
CREATE TABLE SalesOrders 
(
OrderID int PRIMARY KEY IDENTITY NOT NULL,
OrderNumber int NOT NULL,
UserName varchar(50) NOT NULL
)

CREATE TABLE SalesOrderDetails
(
OrderID int NOT NULL,
Sequence int NOT NULL,
Description varchar(200) NOT NULL,
Price decimal(18, 5) NOT NULL,
CONSTRAINT [PK_SalesOrderDetails] PRIMARY KEY CLUSTERED 
(
[OrderID] ASC,
[Sequence] ASC
),
CONSTRAINT FK_SalesOrderDetails_SalesOrders FOREIGN KEY (OrderID) REFERENCES SalesOrders (OrderID)
    ON UPDATE CASCADE ON DELETE CASCADE
)
```




