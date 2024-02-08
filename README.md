Followed a tutorial on youtube to familiarize myself with the basics of RestfulAPI again (https://www.youtube.com/watch?v=_uZYOgzYheU&list=WL&index=7&t=3503s)


- enforce "accept" header setting: in program.cs add option setting 
        - builder.Services.AddControllers(option => {
            option.ReturnHttpNotAcceptable = true;
        }).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

- logging is important :)
-   can utilize dependancy injection by using the built in logger . Pass it into the controller constructor


serilog - to setup install the following and uncomment setting in program.cs
- serilog.sinks.file
- serilog.aspnetcore



entity framework setup database (code first)
console 
- add-migration AddVillaTable
- update-database
