# Lecture #1

##Steps

1. Create empty solution named `EfWithMySql`. This is abberivation from Entity Framework with MySLQ.
*Keep an eye on case*
###Hint:
*New Project window -> Installed -> Templates -> Other Project Types -> Visual Studio Solutions -> BlankSolution*

2. Add console application named `EfFirstContact` to this solution.
2.1 Compile and run it. It should write `monkey` message to the console.

3. Create database initialization script for Todo application.
3.1 Inside project create `SqlScripts` folder. 
3.2 Create `01_Init.sql` SQL script in this folder. 
3.3 Create `Todo` database with one table for todo items. 

*SD: some random data

TodoItem

| Id | Description | TimeCreated | TimeSetToDone |
|----|-------------|-------------|---------------|
| SD | Buy milk    | (some data) | NULL          |
| SD | Call Miki   | (some data) | NULL          |
| SD | Do homework | (some data) | (some data)   |

4. Install `MySql.Data.Entity` NuGet package.
Check out `package.config` which has been updated with project dependencies for MySql.

```
<packages>
  <package id="EntityFramework" version="6.0.0" targetFramework="net452" />
  <package id="MySql.Data" version="6.9.8" targetFramework="net452" />
  <package id="MySql.Data.Entity" version="6.9.8" targetFramework="net452" />
</packages>
```
Project references have been updated. Look, there is EntityFramework reference.
`App.config` file has been updated with `entityFramework` section
Packages folder has been created in solution folder. It's not visible in Solution Explorer. Snoop around it.