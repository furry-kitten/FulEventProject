﻿using FO.Models;
using FO.Models.Перечисления;

using System;
using System.Collections.Generic;
using System.Text;

namespace DBLib.Defualts
{
    public class DefaultDBRecords
    {
        List<SHAClasses> shaClasses = new List<SHAClasses>
            {
                new SHAClasses
                {
                    Name = "Begginer",
                    Direction = Direction.JnJ,
                    TotalPoints = 12,
                    Significance = 1
                },
                new SHAClasses
                {
                    Name = "Rising Star",
                    Direction = Direction.JnJ,
                    TotalPoints = 18,
                    Significance = 2
                },
                new SHAClasses
                {
                    Name = "Main",
                    Direction = Direction.JnJ,
                    TotalPoints = 24,
                    Significance = 3
                },
                new SHAClasses
                {
                    Name = "Star",
                    Direction = Direction.JnJ,
                    TotalPoints = 18,
                    Significance = 4
                },
                new SHAClasses
                {
                    Name = "Champion",
                    Direction = Direction.JnJ,
                    TotalPoints = 0,
                    Significance = 5
                },
                new SHAClasses
                {
                    Name = "E",
                    Direction = Direction.Classic,
                    TotalPoints = 4,
                    Significance = 1
                },
                new SHAClasses
                {
                    Name = "D",
                    Direction = Direction.Classic,
                    TotalPoints = 18,
                    Significance = 2
                },
                new SHAClasses
                {
                    Name = "C",
                    Direction = Direction.Classic,
                    TotalPoints = 24,
                    Significance = 3
                },
                new SHAClasses
                {
                    Name = "B",
                    Direction = Direction.Classic,
                    TotalPoints = 18,
                    Significance = 4
                },
                new SHAClasses
                {
                    Name = "A",
                    Direction = Direction.Classic,
                    TotalPoints = 0,
                    Significance = 5
                }
            };

        public List<SHAClasses> SHAClasses
        {
            get => shaClasses;
            set => shaClasses = value;
        }
    }
}
