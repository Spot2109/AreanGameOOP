﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Staff : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        public Aspect EqAspect { get; private set; }

        public Staff(string name)
        {
            Name = name;
            BlockingPower = 10;

            AspectList tempList = new AspectList();
            Aspect temp = tempList.getAspect();
            EqAspect = temp;

            AttackDamage = 15 * (EqAspect.Amplifier + 1);
        }
    }
}
