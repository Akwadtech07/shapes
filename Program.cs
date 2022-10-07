using System;
using triangle;
using Circle;
using OOP;
namespace SHAPES
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Triangle n = new Triangle();
        //    Console.WriteLine($"Enter the height of the triange:");
        //    n.height = double.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter the base of the triange:");
        //    n.baze = double.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter the length of the triange:");
        //    n.length= double.Parse(Console.ReadLine());
        //    n.Area();
        //    n.Perimeter();


        //     circle A = new circle();
        //    Console.WriteLine($"Enter the circumfrence of the circle:");
        //    A.circumfrence = double.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter the radius of the circle:");
        //    A.radius = double.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter the radius of the circle:");
        //    A.diameter = double.Parse(Console.ReadLine());
        //    Console.WriteLine($"Enter the diameter of the circle:");
           
        //    A.pi=22/7;
        //    A.arear();
        //    A.circumfrenz();
        //    A.diameta();

        student student1 = new student ();
        student1.Name= "Beverly King";
        student1.DOB=  "2001/01/09";
        student1.StateOfOrigin = "lagos state";
        student1.SetAge(student1.DOB);
        

        student student2 = new student("adeoye fausat","2000/10/18", "osun state");

        student2.SetName("Akinwande fausat");
        

        student.prinStudentInfo(student1);
        student.prinStudentInfo(student2);
        
           
            
        }
    }
}
