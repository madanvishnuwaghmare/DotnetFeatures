

Chapter 1 :Establish a Database Connection and Basic Serice Citi
View --> Other Windows --> Endpoint Explorer
Chapter 1 :Establish a Database Connection
Target Fetch the Results of Cities and placess to visit.

OpenAPI Support is Swagger 


Step 1 Install Microsoft.EntityFrameworkCore.SqlServer
Step 2 Install Microsoft.EntityFrameworkCore.Tools
step 3 Create a singleton ApplicationDBContext class which inherits from DbContext and has property Citis as DBSEt
and Models/city class 
step 4 Add	connection String in appsettings.json
step 5  Adddb context to program.cs
step 6 Program Add a web Services 
		a) add controller inherit from ControllerBase with [ApiController] and [Route("api/[controller]")] attributes
		b) Inversion of contorl injection of DbContext in controller constructor
		c) add method GetCities() and GetPlaces() with [HttpGet] attribute
step 6 Tools --Nuget Package Manager Console
step 7 Add-Migration InitialCreate
step 8 Update-Database
step 9 http://localhost:5266/api/Citi

 

Learning Outcome:
CloudService.http Is a endppoint explorer 

What are different Enity framework approaches ?

Practically 2 in Dotnet core 10 

Code First with migration 

And Database first for legacy applicaiton 
EDMx Is rmoved 

Scafolding are used to generate the model


| Approach               | Database exists first? | Migration   | Typical use                    |
| ---------------------- | ---------------------- | ----------- | ------------------------------ |
| **Code First**         | ❌                      | ✅           | New applications               |
| **Database First**     | ✅                      | Usually ❌   | Existing/legacy DB             |
| **Model First / EDMX** | ❌                      | EF6 concept | Not used in modern EF Core     |
| **Scaffolding**        | ✅                      | Usually ❌   | Generate EF Core model from DB |


Database First typically uses:
>>dotnet ef dbcontext scaffold

For example:

>>dotnet ef dbcontext scaffold "Server=...;Database=Finance;" \
Microsoft.EntityFrameworkCore.SqlServer \
--output-dir Models
========================================================

Chapter 2 : Create a Web API with CRUD Operations
a) Post Method
b) Add Swagger UI for API Testing
c) Use Postman to test the API endpoints
 

 Step 1 create CTDTO as a New dataTranasfer object class with properties of city and places
 step 2 Modify controller [Route("api/[controller]/")] attributes
 step 3 Add Post Method  with [HttpPost] attribute [Route("AddCitis")] and accept CTDTO as parameter
 step 4  Add Swagger UI for API Testing
 step 5 Use Postman to test the API endpoints postman Url : http://localhost:5266/api/Citi/AddCitis
 step Under the headers tab add Content-Type as application/json and in the body tab select raw and add the json data for city 
 {
    "id": 7,
    "cityName": "Delhi",
    "cityDescription": " the capital"
 }
 step 6 Dont Forget to add the migration and update the database _context.SaveChanges(); after adding the new property in the model class 

