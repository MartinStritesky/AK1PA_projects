using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK1PA_exercises
{
    internal class Airplanes
    {
        public string Name { get; set; }
        public double FuelTankVolume { get; set; }
        public double AverageSpeed { get; set; }
        public double MaxSpeed { get; set; }

        public Airplanes(string name, double tankVolume, double aspeed, double mspeed)
        {
            Name = name;
            FuelTankVolume = tankVolume;
            AverageSpeed = aspeed;
            MaxSpeed = mspeed;
        }


    }
}
