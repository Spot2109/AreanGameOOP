using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Sorcerer : Hero
    {
        private double arcaneCoef; 
        private Random rnd = new Random();
        
        public Sorcerer(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            arcaneCoef = rnd.Next(0,100) / 100;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage * (arcaneCoef + 1);

            return realDamage;
        }

        public override double Defend(double damage)
        {
            return base.Defend(damage - damage * arcaneCoef);
        }
    }
}
