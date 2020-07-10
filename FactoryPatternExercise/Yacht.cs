using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Yacht : IBoat
    {
        public Yacht()
        {

        }
        public void Ride()
        {
            Console.WriteLine("Let's get on the river");
        }

    }
}
