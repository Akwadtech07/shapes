using System;

namespace OOP
{
    class student
    {
        public string Name;
        public string MatricNO;
        public int Age;
        public string DOB;
        public string StateOfOrigin;
        // default constructor
        public student(){

        }
        // definde constructor
        public student(string name, string DOB, string stateOfOrigin){
            this.Name=name;
            this.DOB= DOB;
            this.StateOfOrigin= stateOfOrigin;
            this.Age = CalcAge(DOB);
            this.MatricNO = MtrcGen();


        }

        //  print method

        public static void prinStudentInfo(student student){
            Console.WriteLine("name: "+ student.Name);
            Console.WriteLine("DOB: "+ student.DOB);
            Console.WriteLine("State: "+ student.StateOfOrigin);
            Console.WriteLine("Age: "+ student.Age);
            Console.WriteLine("matricNO: "+ student.MatricNO);
        }

        //  Calc Age  Method
        
        
        private int CalcAge(string DateOfBirth)
        {
            DateTime dob = DateTime.Parse(DateOfBirth);
            int presentYear = System.DateTime.Today.Year;
            int age = DateTime.Today.Year - dob.Year;
            return age;
        }

        // getters and setters
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetState(string stateOfOrigin)
        {
          this.StateOfOrigin =  stateOfOrigin;  
        }
        public string GetState()
        {
            return this.StateOfOrigin;
        }
        public void SetDob( string DOB)
        {
            this.DOB = DOB;

        }
        
        public string GetDob()
        {
            return this.DOB;
        }

        public int GetAge()
        {
            return this.Age;
        }

        public void SetAge(string DateOfBirth)
        {
            this.Age = CalcAge(DateOfBirth);
        }

        private string MtrcGen()
        {
            Random CheckMate = new Random();
            int M = CheckMate.Next(5000, 100000);
            return M.ToString();
        }

        private string AgeCheck()
        {
            string A = null;
            if (this.Age>= 16)
            {
                A= $"{MtrcGen()}-{this.Name}";
                
            }
            return A;
        }






        // ass Q! if the student is >= 16 create a method taht generates matric number with a random generator using student name 
        // Q2 if age is greater >=16 generate matric number

    }
}