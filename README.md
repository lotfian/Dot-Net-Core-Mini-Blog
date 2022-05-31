 <img align="left" width="116" height="116" src="https://s6.uupload.ir/files/666_whzg.png" />
 
# Dot-Net-Core-Mini-Blog
A simple Blog App in ASP.NET Core (Clean Architecture Solution )



## This is a simple Blog App with  ASP.NET Core 6 following the principles of Clean Architecture. 


<br>
 <img align="center" width="600" height="300" src="https://s6.uupload.ir/files/screenshot_96mh.png" />


## Technologies:
* ASP.NET Core 6
* Entity Framework Core 6
* Bootstrap V4
* FluentValidation

## Getting Started:
1.Install the latest .NET 6 SDK

2.Navigate to `Src/WebUI` and launch the project using `dotnet run`

## Database Configuration

Verify that the **BlogContext** connection string within **appsettings.json** points to a valid SQL Server instance. 

When you run the application the database will be automatically created (if necessary) and the latest migrations will be applied.

### Database Migrations

To use `dotnet-ef` for your migrations add the following flags to your command (values assume you are executing from repository root)

* `--project src/Infrastructure` (optional if in this folder)
* `--startup-project src/WebUI`
* `--output-dir Persistence/Migrations`

For example, to add a new migration from the root folder:

 `dotnet ef migrations add "InitialDB" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations`

## Support

If you are having problems, please let us know by [Send Email](mailto:lotfian70@gmail.com).
