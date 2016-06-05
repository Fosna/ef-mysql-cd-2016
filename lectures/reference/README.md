# Lecture #1

#Steps

#### 1. Create empty solution named `EfWithMySql`. This is abberivation from Entity Framework with MySLQ.
*Keep an eye on case*
###Hint:
*New Project window -> Installed -> Templates -> Other Project Types -> Visual Studio Solutions -> BlankSolution*

#### 2. Add console application named `EfFirstContact` to this solution.
2.1. Compile and run it. It should write `monkey` message to the console.

#### 3. Create database initialization script for Todo application.
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

#### 4. Install `MySql.Data.Entity` NuGet package.
Check out `package.config` which has been updated with project dependencies for MySql.

```
<packages>
  <package id="EntityFramework" version="6.0.0" targetFramework="net452" />
  <package id="MySql.Data" version="6.9.8" targetFramework="net452" />
  <package id="MySql.Data.Entity" version="6.9.8" targetFramework="net452" />
</packages>
```
Project references have been updated. Look, there is EntityFramework reference.
`App.config` file has been updated with `entityFramework` section.
Packages folder has been created in solution folder. It's not visible in Solution Explorer. Snoop around it.

#### 5. Create Todo database Entity Framework database first model.
5.1. Add `02_GenModelFix` to SqlScripts folder.

5.2. Add one command to this script `set global optimizer_switch='derived_merge=off';`. It fixes issue with Entity Framework database first approach for MySQL databases.

5.3. Execute this script on `Todo` database.

5.4. Add ADO.NET Entity Data Model to project with name `TodoModel`.

5.5. EF Designer from database.

5.6. Create new connection to Todo database. Use *MySQL Database (MySQL Data Provider)*. Make use of Test Connection window.

5.7. Yes, include the sensitive data in connection string.

5.8. Select all tables. There is only one table. *Pluralize or singularize... bla bla* shouldn't be checked. *Include foreign key... bla bla* should be checked.

5.9. Save and close `TodoModel.edmx` file. Build solution. Check out `ConnectionStirngs` section in `App.config`.

#### 6. Connect to database. See if some todo items exist.
```
var db = new TodoEntities();
var todoItemsExist = db.todoitem.Any();
Console.WriteLine(todoItemsExist);
```
Output should be `True`.

#### 7. Write all tasks to console when application starts.
Extract logic to `TodoApp` class.


