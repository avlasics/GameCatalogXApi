# GameCatalogXApi
The api project will automatically create a database when it is run in debug mode for the first time 
so it is necessary to modify the connection string in web.config

Database gets created and seeded only if it does not already exist.

This is the default connection string - it will need to be changed depending on how you have set up SQL Server:
```xml
  <connectionStrings>
    <add name="GameCatalogX" connectionString="data source=localhost;initial catalog=catalogx;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
  </connectionStrings>
```

By default, it will run on IISEXPRESS on port 9000

Swagger page can be accessed here:
http://localhost:9000/swagger/ui/index

There are a few unit tests also
