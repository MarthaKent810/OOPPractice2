using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {


        static void Main(string[] args)
        {
            Dog wooffie = new Dog(15, 120, 900, 0);
            wooffie.Run();
            Dog spot = new Dog();
            spot.RunningSpeed = 25;
            spot.Run();
            wooffie.RunningSpeed = 100;
            wooffie.Run();
            spot.Run();
        }
    }
}

