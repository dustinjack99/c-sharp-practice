using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable / Datatype Lesson
            //Console.WriteLine("Enter your name, or else!");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age, or else!");
            //string age = Console.ReadLine();
            //Console.WriteLine("How's if goin', " + name + "? You are: " + age);

            //Import Calculator
            //var Calc = new ClassCalculator();
            //Calc.Calculator();

            //Import Madlib
            //var Mad = new ClassMadlib();
            //Mad.Madlib();

            //Import Array / Method Lesson
            //var ArrMeth = new ClassArrayMethod();
            //ArrMeth.ArrayMethodLesson();

            //Import Loop Lessons
            //var If = new ClassLoopLessons();
            //If.LoopLessons();

            //Class / Objects Lesson
            //Book book1 = new Book("Return of the King", "J.R.R. Tolkein", 347); 
            //Book book2 = new Book("Twilight", "Stephanie Meyer", 148); ;
            //Console.WriteLine(book1.title);
            //Console.WriteLine(book2.title);

            //Class Methods
            //Student student1 = new Student("Jim", "Business", 2.8);
            //Student student2 = new Student("Pam", "Art", 3.6);
            //Console.WriteLine(student1.Honors());
            //Console.WriteLine(student2.Honors());

            //Static Classes / Methods
            //UsefulTools.SayHi("Toots");

            //Inheritance
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Chef chef = new Chef();
            chef.MakeSpecialDish();
        }
    }
}
