using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        { 
        }
        public bool HasTrunk;
        public override void DriveAbstract()          //override the abstract method of the vehicle class
        {
            Console.WriteLine("Car is abstract");
        }
    }
}
