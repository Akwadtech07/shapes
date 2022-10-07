using System;
namespace triangle
{
    class Triangle
    {
        public double height;
        public double baze;

        public double length;

        public void Area()
        {  
           double A= (baze*height)/2;
            Console.WriteLine(A);        
            
        }
        public void Perimeter()
        {
           
           double P= height + baze + length; 
            Console.WriteLine(P);
        }

    }



}
