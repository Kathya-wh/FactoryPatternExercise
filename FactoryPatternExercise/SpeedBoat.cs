using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class SpeedBoat : IBoat
    {
        public SpeedBoat()
        {

        }

        public void Ride()
        {
            Console.WriteLine("The Boat is riding fast!");
        }


    }
}
