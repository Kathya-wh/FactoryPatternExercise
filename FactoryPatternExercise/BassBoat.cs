using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class BassBoat : IBoat 
    {
        public BassBoat()
        {

        }

        public void Ride()
        {
            Console.WriteLine("The Bass boat is a smooth ride!");
        }


    }
}
