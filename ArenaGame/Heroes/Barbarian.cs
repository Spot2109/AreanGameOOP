using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Barbarian : Hero
    {

        public IWeapon Weapon2 {  get; set; }
        public Barbarian(string name, double armor, double strenght, IWeapon weapon, IWeapon weapon2) : base(name, armor, strenght, weapon)
        {
            Weapon2 = weapon2;
        }

        public override double Attack()
        {
            if(Weapon2 != null) 
            { 
                double totalDamage = Strenght + Weapon.AttackDamage;
                double realDamage = totalDamage + (Weapon2.AttackDamage / 0.5);
                return realDamage;
            }
            return base.Attack();            
        }

        public override double Defend(double damage)
        {
            if(Weapon2 != null) 
            {
                return base.Defend(damage + Weapon2.AttackDamage * 2);
            }
            return base.Defend(damage);
        }

    }
}
