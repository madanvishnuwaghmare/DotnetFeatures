Things which i would be practising are


New things find the 
CloudService.http Is a endppoint explorer 
View --> Other Windows --> Endpoint Explorer
Chapter 1 :Establish a Database Connection
Target Fetch the Results of Cities and placess to visit.

OpenAPI Support is Swagger 


Step 1 Install Microsoft.EntityFrameworkCore.SqlServer
Step 2 Install Microsoft.EntityFrameworkCore.Tools
step 3 Create DBContext and Models
step 4 Program Add Services db context 
step 5 Add Connection String in appsettings.json
step 6 Tools --Nuget Package Manager Console
step 7 Add-Migration InitialCreate
step 8 Update-Database

 

What are different Enity framework approaches 

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

