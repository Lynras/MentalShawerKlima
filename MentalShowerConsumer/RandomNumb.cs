using System;

namespace MentalShowerConsumer
{
    public class RandomNumb
    {

        public static int Rando(int first, int secound)
        {
            return new Random().Next(first, secound);
        }

    }
}