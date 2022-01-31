
# Microservices
  $  mkdir dotnet6mywebappmvc
  $  cd dotnet6mywebappmvc/
  $  dotnet new sln
  $  dotnet new mvc -o APP
  $  dotnet sln add APP
  $  dotnet new gitignore

  $  git init
  $  git add -A
  $  git commit -m "first commit"
  $  git branch -M main
  $  git remote add origin https://github.com/xxx/yyy.git
  $  git push -u origin main

$ mkdir Services
$ cd Services/
$ dotnet new webapi -o App.Services.ProductAPI

$ cd App.Services.ProductAPI
$ dotnet watch run

# add proj to solution via below
$ dotnet sln add Services/App.Services.ProductAPI
# set App.Services.ProductAPI as startup proj [optional]

# PAckages
AutoMapper
AutoMapper.Extensions.Microsoft.DependencyInjection

Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

Swashbuckle.AspNetCore
Swashbuckle.AspNetCore.SwaggerUI
Swashbuckle.AspNetCore.Annotations



# Generic notes:
# Pre req: 
Install .net 6 (.net 6 cli)
Install node.js, npm [optional]
Gitbash
Sourcetree or smartgit
Install Visual Studio Code with below extenstions [some are optional]

    c#
    c# extensions
    nuget gallery
    material icon theme
    Bracket Pair Colorizer

via nuget
>asset ( generate .net asset for build and debug)
> for Swagger dev interface
SwashBuckle.AspNetCore.MicrosoftExtensions 
Swashbuckle.AspNetCore.SwaggerGen  
Swashbuckle.AspNetCore.SwaggerUI  


# setup proj VSC
Autosave
hide bin or other unwanted folder

# dotnet cmds (gitbash)
$dotnet
$dotnet -h
$dotnet new -h
$dotnet new -l

# new proj setup
$cd [projects location dir]
$mkdir dotnet6projectname
$cd dotnet6projectname
$dotnet new sln
$dotnet new [templatename like web/webapp/webapi/angular/mvc/console] -o APP
$dotnet sln add APP
$dotnet new gitignore

# run dotnet project
-open project is VSC
-open terminal
-cd into APP directory of project
$dotnet run
* click on localhost url in console to see application in browser, if page is not loading ( might need to add path like /weatherforecast for some templates like webapi, others work directly) port can be any available unless you setup/update in APP\Properties\launchSettings.json
$dotnet watch run
- cd into client dir to run angular project with ng serve

# git repo - setup empty repo 
git init
git add -A
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/xxxx/[reponame].git
git push -u origin main


# migrations in visual studio code
$dotnet tool install --global dotnet-ef
#verify via dotnet ef
#run below (make sure app is not running via dotnet watch run or dotnet run)
$dotnet ef migrations add migration-name
$dotnet ef database update
$dotnet ef migrations remove


Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation

# Scaffold pages from Model.cs file
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-6.0&tabs=visual-studio-code

Add Model file in Model Dir.

SEtup packages


dotnet tool uninstall -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool uninstall -g dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

Run below cmd to Scafold [Change params as needed as per Model]
dotnet-aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

Add migration

$ dotnet ef migrations add InitialCreate --context MvcMovieContext
$ dotnet ef database update --context MvcMovieContext



