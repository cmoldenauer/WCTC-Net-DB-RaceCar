﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    internal class Gordon : Driver
    {
        public Gordon(RaceCar car) : base(car)
        {
            Name = "Gordon";
            SkillLevel = 9;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}