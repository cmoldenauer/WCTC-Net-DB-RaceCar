using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Drivers;

namespace RaceTrack.RaceTrack.Cars
{
    internal class ToyotaSupra : RaceCar
    {
        public ToyotaSupra()
        {
            Name = "Supra";
            TopSpeed = 155;
            Position = 1;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name}'s engine roars to life and begins purring!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} ra!");
            base.Brake();
        }
    }
}
