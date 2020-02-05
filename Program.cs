using System;

namespace ConsoleApp4
{
    class Plane
    {
        string color = "White";
        int maxSpeed = 20000;
 
        static void Main(string[] args)
        {
            Plane myObj = new Plane();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            Console.ReadLine();
           
        }
    }
}
