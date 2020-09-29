using System;
using System.Collections.Generic;
using System.Text;

namespace More_Practice
{
    enum School
    {
        //enums are automatically indexed
        //0
        Hogwarts,
        //1
        Harvard,
        //2
        MIT
    }
    class SchoolTracker
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {


            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                    newStudent.School = (School)Util.Console.AskInt("School Name: (type corresponsing number): \n 0: Hogwarts \n 1: Harvard \n 2: MIT \n");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = Util.Console.AskInt("Student Phone: ");

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;

                    foreach (var student in students)
                    {
                        Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                    }
                    Exports();
                }
                //You can write more than one catch block!!
                catch (FormatException msg)
                {
                    Console.WriteLine(msg);
                }
                catch (Exception)
                {

                    Console.WriteLine("Error: Incorrect value entered.");
                }
            }
        }

        static void Import()
        {
            var importedStudent = new Student("Alan", 99, "birthday", "address", 123);
            Console.WriteLine(importedStudent);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }
    }
    class Member
    {
        //this is known as the field: 
        //they become C# properties when they are given the getter and setter functions
        public string Name;
        public string Birthday;
        public string Address;
        //lowercase variables are considered private
        protected int phone;

        //setting a property 
        //used like a class variable, but behaves like a function
        public int Phone
        {
            set { phone = value; }
        }
    }
    class Student : Member
    {
        //static variables are shared across all instances - wicked cool
        //shared by the class and not the instance of the class
        static public int Count = 0;
        public int Grade;
        public School School;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }

    class Teacher : Member
    {
        public string Subject;



    }

}
