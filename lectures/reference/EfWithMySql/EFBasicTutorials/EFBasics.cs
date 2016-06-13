﻿using SweetStuff.Dump;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Spatial;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicTutorials
{
    class EFBasics
    {

        public static void ChangeTrackingDemo()
        {
            Console.WriteLine("*** ChangeTrackingDemo Start ***");
            using (var ctx = new SchoolDbEntities())
            {
                ctx.Configuration.ProxyCreationEnabled = false;

                Console.WriteLine("Find Student");
                var std1 = ctx.students.Find(1);

                Console.WriteLine("Context tracking changes of {0} entity.", ctx.ChangeTracker.Entries().Count());

                DisplayTrackedEntities(ctx.ChangeTracker);

                Console.WriteLine("Find Standard");

                var standard = ctx.standards.Find(1);

                Console.WriteLine("Context tracking changes of {0} entities.", ctx.ChangeTracker.Entries().Count());
                Console.WriteLine("");
                Console.WriteLine("Editing Standard");

                standard.StandardName = "Edited name";
                DisplayTrackedEntities(ctx.ChangeTracker);


                teacher tchr = new teacher() { TeacherName = "new teacher" };
                Console.WriteLine("Adding New Teacher");

                ctx.teachers.Add(tchr);
                Console.WriteLine("");
                Console.WriteLine("Context tracking changes of {0} entities.", ctx.ChangeTracker.Entries().Count());
                DisplayTrackedEntities(ctx.ChangeTracker);

                Console.WriteLine("Remove Student");
                Console.WriteLine("");

                ctx.students.Remove(std1);
                DisplayTrackedEntities(ctx.ChangeTracker);
            }
            Console.WriteLine("*** ChangeTrackingDemo Finished ***");

        }
        private static void DisplayTrackedEntities(DbChangeTracker changeTracker)
        {
            Console.WriteLine("");

            var entries = changeTracker.Entries();
            foreach (var entry in entries)
            {
                Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
                Console.WriteLine("Status: {0}", entry.State);
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
        }
        public static void DBEntityEntryDemo()
        {
            Console.WriteLine("*** DBEntityEntryDemo Start ***");
            using (var dbCtx = new SchoolDbEntities())
            {
                //get student whose StudentId is 1
                var student = dbCtx.students.Find(1);

                //edit student name
                student.StudentName = "Edited name";

                //get DbEntityEntry object for student entity object
                var entry = dbCtx.Entry(student);
                entry.State = System.Data.Entity.EntityState.Modified;

                //get entity information e.g. full name
                Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);

                //get current EntityState
                Console.WriteLine("Entity State: {0}", entry.State);

                Console.WriteLine("********Property Values********");

                foreach (var propertyName in entry.CurrentValues.PropertyNames)
                {
                    Console.WriteLine("Property Name: {0}", propertyName);

                    //get original value
                    var orgVal = entry.OriginalValues[propertyName];
                    Console.WriteLine("     Original Value: {0}", orgVal);

                    //get current values
                    var curVal = entry.CurrentValues[propertyName];
                    Console.WriteLine("     Current Value: {0}", curVal);
                }

            }
            Console.WriteLine("*** DBEntityEntryDemo Finished ***");

        }

        public static void CRUDOperationInConnectedScenarioDemo()
        {
            Console.WriteLine("*** CRUDOperationInConnectedScenarioDemo Start ***");

            using (var context = new SchoolDbEntities())
            {
                var projectionQuery = from s in context.students
                                      select s;

                var studentList = projectionQuery.ToList<student>();

                //Perform create operation
                context.students.Add(new student() { StudentName = "New Student from CRUD Operation" });

                //Perform Update operation
                student studentToUpdate = studentList.Where(s => s.StudentID == 1).FirstOrDefault<student>();
                studentToUpdate.StudentName = "Edited Student Name";

                //Perform delete operation
                if (studentList.Where(s => s.StudentID == 10).FirstOrDefault<student>() != null)
                    context.students.Remove(studentList.Where(s => s.StudentID == 10).FirstOrDefault<student>());

                //Execute Inser, Update & Delete queries in the database
                context.SaveChanges();

            }
            Console.WriteLine("*** CRUDOperationInConnectedScenarioDemo Finished ***");
        }

        public static void ReadDataUsingStoredProcedure()
        {
            Console.WriteLine("*** ReadDataUsingStoredProcedure Start ***");

            Console.WriteLine("Not supported.");

            Console.WriteLine("*** ReadDataUsingStoredProcedure Finished ***");
        }

        public static void CUDOperationUsingStoredProcedureDemo()
        {
            //Map Insert, Update, Delete stored procedure info for Student entity before runing following code
            Console.WriteLine("*** CUDOperationUsingStoredProcedureDemo Start ***");

            Console.WriteLine("Not supported.");

            Console.WriteLine("*** CUDOperationUsingStoredProcedureDemo Finished ***");
        }

        public static void FindEntityDemo()
        {
            Console.WriteLine("*** FindEntityDemo Start ***");
            using (var context = new SchoolDbEntities())
            {
                var stud = context.students.Find(1);

                Console.WriteLine(stud.StudentName + " found");

            }
            Console.WriteLine("*** FindEntityDemo Finished ***");
        }

        public static void GetPropertyValuesDemo()
        {
            Console.WriteLine("*** GetPropertyValuesDemo Start ***");

            using (var context = new SchoolDbEntities())
            {
                var stud = context.students.Include("StudentAddress").Where(s => s.StudentID== 1).FirstOrDefault<student>();
                stud.StudentName = "Changed Student Name";

                //Get reference reference property eg. foerignkey entity (single entity)
                var referenceProperty = context.Entry(stud).Reference(s => s.standard);

                //get collection navigation property information (one-to-many or many-to-many property) eg. Student.Courses
                var collectionProperty = context.Entry(stud).Collection<course>(s => s.courses);

                string propertyName = context.Entry(stud).Property("StudentName").Name;
                string currentValue = context.Entry(stud).Property("StudentName").CurrentValue.ToString();
                string originalValue = context.Entry(stud).Property("StudentName").OriginalValue.ToString();
                bool isChanged = context.Entry(stud).Property("StudentName").IsModified;
                var dbEntity = context.Entry(stud).Property("StudentName").EntityEntry;

                Console.WriteLine("StudentName property values: ");
                Console.WriteLine("Property Name:" + propertyName);
                Console.WriteLine("current value:" + currentValue);
                Console.WriteLine("original value:" + originalValue);
                Console.WriteLine("isModified:" + isChanged.ToString());
            }

            Console.WriteLine("*** GetPropertyValuesDemo Finished ***");
        }

        public static void LocalDemo()
        {

            Console.WriteLine("*** LocalDemo Start ***");
            using (var context = new SchoolDbEntities())
            {
                context.students.Add(new student() { StudentName = "New Student for Local demo" });

                context.students.Remove(context.students.Find(5));


                // Loop over the unicorns in the context.
                Console.WriteLine("***In Local: ");
                foreach (var student in context.students.Local)
                {
                    Console.WriteLine("Found {0}: {1} with state {2}",
                                      student.StudentID, student.StudentName,
                                      context.Entry(student).State);
                }

                // Perform a query against the database.
                Console.WriteLine("\n***In DbSet query: ");
                foreach (var student in context.students)
                {
                    Console.WriteLine("Found {0}: {1} with state {2}",
                                      student.StudentID, student.StudentName,
                                      context.Entry(student).State);
                }
                Console.WriteLine("*** LocalDemo Finished ***");

            }
        }

        public static void ValidationErrorDemo()
        {
            try
            {
                Console.WriteLine("*** ValidationErrorDemo Start ***");
                using (var context = new SchoolDbEntities())
                {
                    context.students.Add(new student() { StudentName = "" });
                    context.standards.Add(new standard() { StandardName = "" });

                    Console.WriteLine("***ValidationErrorDemo Start");

                    context.SaveChanges();


                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        Console.WriteLine("Error Property Name {0} : Error Message: {1}",
                                          error.PropertyName, error.ErrorMessage);
                    }
                }
                Console.WriteLine("*** ValidationErrorDemo Finished ***");
            }
        }

        public static void LazyLoadingDemo()
        {
            Console.WriteLine("*** LazyLoadingDemo Start ***");

            Console.WriteLine("Broken for MySQL");

            using (var context = new SchoolDbEntities())
            {
                context.Database.Log = Console.Write;
                //Loading students only
                IList<student> studList = context.students.ToList<student>();

                student student = studList.Where(s => s.StudentID == 1).FirstOrDefault<student>();

                //Loads Student address for particular Student only (seperate SQL query)
                standard std = student.standard;
                Console.WriteLine(std.DumpJson());
            }
            Console.WriteLine("*** LazyLoadingDemo Finished ***");
        }

        public static void ExplicitLoadingDemo()
        {
            Console.WriteLine("*** ExplicitLoadingDemo Start ***");

            using (var context = new SchoolDbEntities())
            {
                //Loading students only
                IList<student> studList = context.students.ToList<student>();

                student std = studList.Where(s => s.StudentID == 1).FirstOrDefault<student>();

                //Loads Standard for particular Student only (seperate SQL query)
                context.Entry(std).Reference(s => s.standard).Load();

                //Loads Courses for particular Student only (seperate SQL query)
                context.Entry(std).Collection(s => s.courses).Load();
            }

            Console.WriteLine("*** ExplicitLoadingDemo Finished ***");
        }

        public static void DynamicProxyDemo()
        {
            Console.WriteLine("*** DynamicProxyDemo Start ***");

            Console.WriteLine("Not relevant for Carpe Diem course.");

            using (var context = new SchoolDbEntities())
            {
                var stud1 = context.students.Include("Standard.Teachers").Where(s => s.StudentName == "Student1")
                        .FirstOrDefault<student>();

                var stud = context.students.Include("Standard.Teachers").Where(s => s.StudentName == "Student1")
                           .FirstOrDefault<student>();
                //getting POCO Proxy object
                var studentPOCOProxy = context.students.Find(1);

                Console.WriteLine("Proxy Type: " + studentPOCOProxy.ToString());

                //get actual type of POCO Proxy object
                Type pocoType = studentPOCOProxy.GetType().BaseType;
                Console.WriteLine("Actual type of Proxy: " + pocoType.ToString());

                //Disable Proxy creation
                context.Configuration.ProxyCreationEnabled = false;

                //Getting POCO object (Plain Old CLR Object)
                student stdPOCO = context.students.Find(1);

            }
            Console.WriteLine("*** DynamicProxyDemo Finished ***");
        }

        public static void RawSQLtoEntityTypeDemo()
        {
            Console.WriteLine("*** RawSQLtoEntityTypeDemo Start ***");
            using (var context = new SchoolDbEntities())
            {
                var studentList = context.students.SqlQuery("Select * from Student").ToList<student>();

                var studentName = context.students.SqlQuery("Select StudentId, StudentName, StandardId, RowVersion from Student where StudentId =1").ToList();

            }
            Console.WriteLine("*** RawSQLtoEntityTypeDemo Finished ***");
        }

        public static void RawSQLCommandDemo()
        {
            Console.WriteLine("*** RawSQLCommandDemo Start ***");
            using (var context = new SchoolDbEntities())
            {
                //Get student name of string type
                string standardName = context.Database.SqlQuery<string>("Select standardName from Standard where standardid=1").FirstOrDefault<string>();

                //Update command
                int noOfRowUpdate = context.Database.ExecuteSqlCommand("Update student set studentname ='changed student by command' where studentid=1");
                //Insert command
                int noOfRowInsert = context.Database.ExecuteSqlCommand("insert into student(studentname) values('New Student')");
                //Delete command
                int noOfRowDeleted = context.Database.ExecuteSqlCommand("delete from student where studentid=0");

            }
            Console.WriteLine("*** RawSQLCommandDemo Finished ***");
        }

        public static void EntitySQLDemo()
        {
            Console.WriteLine("*** EntitySQLDemo Start ***");
            using (var context = new SchoolDbEntities())
            {
                string sqlString = "SELECT VALUE st FROM SchoolDBEntities.Students " +
                           "AS st WHERE st.StudentID = 1";
                var objctx = (context as IObjectContextAdapter).ObjectContext;


                ObjectQuery<student> student = objctx.CreateQuery<student>(sqlString);
                student std = student.FirstOrDefault<student>();

                Console.WriteLine("*** EntitySQLDemo Finished ***");

            }
        }

        public static void EntitySQLUsingEntityConnectionDemo()
        {
            Console.WriteLine("*** EntitySQLUsingEntityConnectionDemo Start ***");
            using (var con = new EntityConnection("name=SchoolDBEntities"))
            {
                con.Open();
                EntityCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT VALUE st FROM SchoolDBEntities.Students as st where st.StudentID = 1";
                Dictionary<int, string> dict = new Dictionary<int, string>();
                using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {
                        int a = rdr.GetInt32(0);
                        var b = rdr.GetString(1);

                        dict.Add(a, b);
                    }
                }
            }

            Console.WriteLine("*** EntitySQLUsingEntityConnectionDemo Finished ***");


        }

        public static void SetValuesDemo()
        {
            Console.WriteLine("*** SetValuesDemo Start ***");
            StudentDTO studDTO = new StudentDTO();
            studDTO.StudentName = "StudentName from DTO";

            using (var ctx = new SchoolDbEntities())
            {
                var stud = ctx.students.Find(1);

                var studEntry = ctx.Entry(stud);
                studEntry.CurrentValues.SetValues(studDTO);
                Console.WriteLine("****SetValuesDemo Start: ");

                foreach (var propertyName in studEntry.CurrentValues.PropertyNames)
                {
                    Console.WriteLine("Property {0} has value {1}",
                                      propertyName, studEntry.CurrentValues[propertyName]);
                }
                Console.WriteLine("*** SetValuesDemo Finished ***");
            }

        }

        public static void SpatialDataTypeDemo()
        {
            Console.WriteLine("*** SpatialDataTypeDemo Start ***");

            Console.WriteLine("Not supported");

            Console.WriteLine("*** SpatialDataTypeDemo Finished ***");

        }

        public static void OptimisticConcurrencyDemo()
        {
            Console.WriteLine("*** OptimisticConcurrencyDemo Start ***");
            student student1WithUser1 = null; 
            student student1WithUser2 = null;

            //User 1 gets student
            using (var context = new SchoolDbEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;
                student1WithUser1 = context.students.Where(s => s.StudentID == 1).Single();
            }
            //User 2 also get the same student
            using (var context = new SchoolDbEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;
                student1WithUser2 = context.students.Where(s => s.StudentID == 1).Single();
            }
            //User 1 updates Student name
            student1WithUser1.StudentName = "Edited from user1";

            //User 2 updates Student name
            student1WithUser2.StudentName = "Edited from user2";
            
            //User 1 saves changes first
            using (var context = new SchoolDbEntities())
            {
                try
                {
                    context.Entry(student1WithUser1).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    Console.WriteLine("Optimistic Concurrency exception occured");
                }
            }

            //User 2 saves changes after User 1. 
            //User 2 will get concurrency exection because CreateOrModifiedDate is different in the database 
            using (var context = new SchoolDbEntities())
            {
                try
                {
                    context.Entry(student1WithUser2).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    Console.WriteLine("Optimistic Concurrency exception occured");
                }
            }
            Console.WriteLine("*** OptimisticConcurrencyDemo Finished ***");
        }

    }

    public class StudentDTO
    {
        public StudentDTO() { }

        //public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}
