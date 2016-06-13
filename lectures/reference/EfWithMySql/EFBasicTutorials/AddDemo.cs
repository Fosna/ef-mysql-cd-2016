﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicTutorials
{
    public class AddDemo
    {
        public static void AddSingleEntity()
        {
            Console.WriteLine("****Starting AddSingleEntity****");

            student newStudent = new student() { StudentName = "Student1" };
            using (var context = new SchoolDbEntities())
            {
                context.students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("New Student Entity has been added with new StudentId= " + newStudent.StudentID.ToString());
            }
            Console.WriteLine("****Finished AddSingleEntity****");

        }

        public static void AddEntityGraph()
        {
            Console.WriteLine("****Starting AddEntityGraph****");

            //Create student in disconnected mode
            student newStudent = new student() { StudentName = "New Single Student" };
            
            //Assign new standard to student entity
            newStudent.standard = new standard() { StandardName = "New Standard" };
            
            //add new course with new teacher into student.courses
            newStudent.courses.Add(new course() { CourseName = "New Course for single student", teacher = new teacher() { TeacherName = "New Teacher" } });

            using (var context = new SchoolDbEntities())
            {
                context.students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("New Student Entity has been added with new StudentId= " + newStudent.StudentID.ToString());
                Console.WriteLine("New Standard Entity has been added with new StandardId= " + newStudent.StandardId.ToString());
                Console.WriteLine("New Course Entity has been added with new CourseId= " + newStudent.courses.ElementAt(0).CourseId.ToString());
                Console.WriteLine("New Teacher Entity has been added with new TeacherId= " + newStudent.courses.ElementAt(0).TeacherId.ToString());
            }

            Console.WriteLine("****Finished AddEntityGraph****");
        
        }
    }
}
