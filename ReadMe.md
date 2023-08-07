# Hectre Harvest Management

## Development Set Up

1. The application using [.Net](https://dotnet.microsoft.com/en-us/download/dotnet/6.0). If it is not available install .net 6 on your local computer. And also make sure to install `dotnet` command line tool and `Entity Framework Core .NET Command-line Tools version 6.0.20`.

3. The application is developed and tested with Microsoft SQL Server. If you do not have access to the already deployed SQL server. Follow these to set it up with docker on your local computer.

* Install docker to your local computer.
* Open the docker desktop and go to settings -> resources and allocated memory of the Docker Engine at least 6 GB.
* In the terminal run `docker pull mcr.microsoft.com/mssql/server` to download the docker image.
* Run SQL server docker image `docker run -e ‘ACCEPT_EULA=Y’ -e ‘SA_PASSWORD=Str0ngPa$$w0rd’ -p 1433:1433 -d mcr.microsoft.com/mssql/server`.

3. Open the project in IDE.
4. Add the SQL connection string to appsetting.json file at ConnectionStrings -> DefaultDatabase.
5. To Initialize the DB you have to run the DB migration. Open the terminal and navigate to `Hectre.HarvestManagement.DataPersistence` folder. and run `dotnet ef --startup-project ../Hectre.HarvestManagement.WebAPI/ database update`.
6. Run the Hectre.HarvestManagement.WebAPI project with IDE.
7. The application uses mock Basic authentication and you can access the API with. 
`Username: admin, password: admin`.
8. To make it easy to try out the APIs I added a Postman collection to the project. Download [Postman](https://www.postman.com/) if you do not have the application. Import the `Harvest Management service.postman_collection.json` to Postman by pressing the import button in the application and selecting the file path.