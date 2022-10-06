using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class GoKart : RaceCar
    {
        public GoKart()
        {
            Name = "Go Kart";
            TopSpeed = 85;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} motor is obnoxiously loud");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} runs over a banana peel and spins over the finish line!");
            base.Brake();
        }
    }
}
