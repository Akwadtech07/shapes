using System;
namespace Circle
{
    class circle
    {
        public  double radius;

        public double circumfrence;

        public double pi;
        public double diameter;

        public void arear()
        {
          double a = pi * (radius*radius); 
          Console.WriteLine(a);
        }

        public void circumfrenz()
        {
            double c = 2 * pi * radius;
            Console.WriteLine(c);
        }
        public void diameta()
        {
            double d = 2 * radius;
            Console.WriteLine(d);
        }

        
    }
}