# ECommerce Project

Walkthrough from Adam Freeman's book Pro ASP.NET Core 3 




dotnet new globaljson --sdk-version 3.1.401 --output ECommerceProject    
dotnet new web --no-https --output ECommerceProject --framework netcoreapp3.1  
dotnet new sln -o ECommerceProject  
dotnet sln ECommerceProject add ECommerceProject  
dotnet new xunit -o ECommerceProject.Tests --framework netcoreapp3.1  
dotnet sln ECommerceProject add ECommerceProject.Tests  
dotnet add ECommerceProject.Tests reference ECommerceProject   

## Chapter 7

### Chapter 7 First Screenshot
![7-1 Screenshot](https://github.com/richminlee/ECommerceProject/blob/master/Screenshot%201.JPG)

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
### Chapter 7 Last Screenshot
![7-2 Screenshot](https://github.com/richminlee/ECommerceProject/blob/master/Screenshot%202.JPG)

## Chapter 8

### Chapter 8 First Screenshot
![8-1 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%208-1.JPG)
### Chapter 8 Second Screenshot
![8-2 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%208-2.JPG)
### Chapter 8 Third Screenshot
![8-3 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%208-3.JPG)
### Chapter 8 Fourth Screenshot
![8-4 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%208-4.JPG)

## Chapter 9

### Chapter 9 First Screenshot
![9-1 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%209-1.JPG)
### Chapter 9 Second Screenshot
![9-2 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%209-2.JPG)
### Chapter 9 Third Screenshot
![9-3 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%209-3.JPG)
### Chapter 9 Fourth Screenshot
![9-4 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%209-4.JPG)

## Chapter 10

### Chapter 10 Screenshot
![10-1 Screenshot](https://github.com/richminlee/ECommerce_Project/blob/master/Screenshot%2010-1.JPG)

