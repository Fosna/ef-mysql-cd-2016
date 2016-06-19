# Lecture #1

## Entity Framework First Contact
Todo application that'll introduce us to Entity Framework with database first approach.

#### 1 Create empty solution named `EfWithMySql`. This is abberivation from Entity Framework with MySQL.
*Keep an eye on letter case.*

Hint:
*New Project window -> Installed -> Templates -> Other Project Types -> Visual Studio Solutions -> Blank Solution*

#### 2 Add console application named `EfFirstContact` to this solution.
2.1. Compile and run it. Make it write `Hello world!` message to the console.

#### 3 Create database initialization script for Todo application.
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

#### 4 Install `MySql.Data.Entity` NuGet package.
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

#### 5 Create Todo database Entity Framework database first model.
5.1 Add `02_GenModelFix` to SqlScripts folder.

5.2 Add one command to this script `set global optimizer_switch='derived_merge=off';`. It fixes issue with Entity Framework database first approach for MySQL databases.

5.3 Execute this script on `Todo` database.

5.4 Add ADO.NET Entity Data Model to project with name `TodoModel`.

5.5 EF Designer from database.

5.6 Create new connection to Todo database. Use *MySQL Database (MySQL Data Provider)*. Make use of Test Connection window.

5.7 Yes, include the sensitive data in connection string.

5.8 Select all tables. There is only one table. *Pluralize or singularize... bla bla* shouldn't be checked. *Include foreign key... bla bla* should be checked.

5.9 Save and close `TodoModel.edmx` file. Build solution. Check out `ConnectionStrings` section in `App.config`.

#### 6 Connect to database. See if some todo items exist.
```
var db = new TodoEntities();
var todoItemsExist = db.todoitem.Any();
Console.WriteLine(todoItemsExist);
```
Output should be `True`.

#### 7 Write all tasks to console when application starts.
Extract logic to `TodoApp` class.

#### 8 Create skeleton for interactive console application.
8.1 Create class `CommandLoop` that will read commands from console and act on them.
List of supported commands:

| Command Constant Name | Command Text |
| --------------------- | ------------ |
| EXIT                  | exit         |
| HELP                  | help         |
| LIST                  | list         |
| ADD                   | add          |
| SET_DONE              | done         |

Support `exit` and `help` for now.
*Help mesage for now can be `TODO: help :)`.*

#### 9 When homework is done...

#### 10 Refactor magic strings from `TodoApp` class to `TodoCommandsClass`
Draft for the class follows
````
class TodoCommands
{
    public const string INVALID = "";
    public const string HELP = "help";
    public const string EXIT = "exit";

    //...

    private static List<string> GetAllCommands()
    {
        var commandList = new List<string>
        {
            //...
            HELP,
            EXIT,
        };
        return commandList;
    }

    public static string ParseCommand(string userInput)
    {
        var command = GetAllCommands().SingleOrDefault(x => x.ToLower() == userInput.Trim().ToLower());
        if (command == null)
        {
            command = INVALID;
        }
        return command;
    }
}

````

## Entity Framework Code First Todo 
Todo application that'll introduce us to Entity Framework with *code first approach*. Functionallity should be the same as in previous todo application we've built.

#### 1 Add console application named `EfCodeFirstTodo` to this solution.
1.1 Compile and run it. Make it write `Hello world!` message to the console.

#### 2 Copy existing program infrastructure from `EfWithMySql` project.
2.1 Copy `Program`, `CommandLoop` and `TodoCommands` classes to new project. Make sure classes are put in appropriate namespaces. Namespaces from this project.

*NOTE: Copy pasting code all over solution is considered bad programming practice. Code should be refactored instead. Right now we don't want to loose focus on refactoring, but stay focused on studying Entity Framework code first approach.*

2.2 Create empty `TodoApp` class. All methods referenced from other parts of application should throw `NotImplementedException`. Example:

```
public class TodoApp
{
    ...

    internal void List()
    {
        throw new NotImplementedException();
    }

    ...
}
```
2.3 Build application. There shouldn't be any compilation errors. However application will crash on start, because todo logic isn't implemented yet.

#### 3 Install `MySql.Data.Entity` NuGet package.

#### 4 Create database for todo app.
4.1 Create `TodoItem` class.

4.2 Create database context named `TodoEntities` which is another class.
```
public class TodoEntities : DbContext
{
    public TodoEntities() : base("TodoEntities")
    {
        Database.SetInitializer(new TodoEntitiesInitializer());
    }

    public DbSet<TodoItem> TodoItems { get; set; }
}
```

4.3 Create class for database initialization `TodoEntitiesInitializer`.
```
// Database will be dropped and created again on every database schema change.
// Use only for development!!!
public class TodoEntitiesInitializer : DropCreateDatabaseAlways<TodoEntities>
{
    protected override void Seed(TodoEntities context)
    {
        context.TodoItems.Add(new TodoItem
        {
            Description = "Buy milk",
            TimeCreated = DateTime.Now.AddDays(-2),
            TimeSetDone = null,
        });
        
        // ... Add some more
        
        base.Seed(context);
    }
}
```

4.4 Add connection string to `TodoCf` (Todo Code First) database.
```
  <connectionStrings>
    <add name="TodoEntities" providerName="MySql.Data.MySqlClient" connectionString="server=localhost;UserId=root;Password=root;database=TodoCf;CharSet=utf8;Persist Security Info=True" />
  </connectionStrings>
```
Notice how this connection string is different that connection string from previous database first project.

4.5 Build to check if everything compiles. :)

4.6 Implement `TodoApp.List()` method.
Data loading API is almost the same as in previous project.

#### 5 Implement rest of todo app functionalities.


## Windows Forms TODO application

#### 1 Create Windows Forms TODO application that saves data to internal list
Project name might be `WfTodo`.
Note: Side effect of this implementation is that application will reset todo list data on application exit.

#### 2 Upgrade application to save data to database instead of internal list
Should you use *database first* or *code first* approach?