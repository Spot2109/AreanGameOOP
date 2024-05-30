using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Aspect EqAspect { get; private set; }

        public Axe(string name)
        {
            Name = name;
            BlockingPower = 10;

            AspectList tempList = new AspectList();
            Aspect temp = tempList.getAspect();
            EqAspect = temp;

            AttackDamage = 35 * (EqAspect.Amplifier + 1);
        }
    }
}
