# ECommerce Project

Walkthrough from Adam Freeman's book Pro ASP.NET Core 3 




dotnet new globaljson --sdk-version 3.1.401 --output ECommerceProject/OutdoorProducts
dotnet new web --no-https --output ECommerceProject/OutdoorProducts --framework netcoreapp3.1
dotnet new sln -o ECommerceProject
dotnet sln ECommerceProject add ECommerceProject/OutdoorProducts 
dotnet new xunit -o ECommerceProject/OutdoorProducts.Tests --framework netcoreapp3.1
dotnet sln ECommerceProject add ECommerceProject/OutdoorProducts.Tests 
dotnet add ECommerceProject/OutdoorProducts.Tests reference ECommerceProject/OutdoorProducts  

### First Screenshot
![First Screenshot](https://github.com/richminlee/ECommerceProject/blob/master/Screenshot%201.JPG)

### Questions:
* What is Entity Framework?
  * Entity Framework is an object-relational mapper (O/RM) that enables .NET developers to work with a database using .NET objects. It eliminates the need for most of the data-access code that developers usually need to write.
* What is a Connection String?
  * Connection strings used by the Entity Framework contain information used to connect to the underlying ADO.NET data provider that supports the Entity Framework. They also contain information about the required model and mapping files.
* What is a Database Context?
  * DbContext is the primary class that is responsible for interacting with the database. It is responsible for the following activities: Querying, Change Tracking, Persisting Data, Caching, Manage Relationship and Object Materialization.
* What is a Model Repository?
  * The Model repository is a relational database that stores the metadata for projects and folders.
* Migration vs Scaffolding?
  * Scaffolding is when you create the Models, Views and Constrollers from the database utilizing Scaffolding from ASP.NET. Migrations are when you update the database from your program.  
* Seeding the database?
  * Seeding the Database is when you add the initial data into the database.
### Last Screenshot
![Last Screenshot](https://github.com/richminlee/ECommerceProject/blob/master/Screenshot%202.JPG)
