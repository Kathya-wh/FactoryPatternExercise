using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSeats;
            bool input = false;
            do
            {

                Console.WriteLine("Enter the amount of seats for the boat you want to create:");

                input = int.TryParse(Console.ReadLine(), out numOfSeats);

            } while (input == false);

            var boat = BoatFactory.GetBoat(numOfSeats);

            boat.Ride();
        }
    }
}
