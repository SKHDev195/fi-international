﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIConsole
{
    public class Team
    {

        public string Name { get; private set; }

        public List<Driver> RacingDrivers { get; set; }

        public float WinProbabilityTeam { get; set; }

        public int CurrentPoints { get; set; } = 0;

        public int TotalPoints { get; set; } = 0;

        public Team(string name, Driver driverOne, Driver driverTwo)
        {
            Name = name;

            RacingDrivers = new List<Driver>();
            RacingDrivers.Add(driverOne);
            driverOne.RacingTeam = this;
            RacingDrivers.Add(driverTwo);
            driverTwo.RacingTeam = this;

            WinProbabilityTeam = 1 - ((1 - RacingDrivers[0].WinProbability) * (1 - RacingDrivers[1].WinProbability));
        }


    }
}
