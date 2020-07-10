using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class BoatFactory
    {
        public static IBoat GetBoat(int seatCount)
        {
            switch (seatCount)
            {
                case 2:
                    return new BassBoat();
                case 3:
                    return new Yacht();
                case 4:
                    return new SpeedBoat();

                default:
                    return new SpeedBoat();


            }
        }   
    }
}
