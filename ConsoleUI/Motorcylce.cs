using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcylce : Vehicle
    {
        public Motorcylce()
        {
        }
        public bool HasSideCart;

        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }
        public override void DriveVirtual()        //because method is virtual in base class, we can either override it or implement our own method   
        {
            Console.WriteLine("Motorcyle is driving like a beast");
        }
    }
}
