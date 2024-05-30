using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Aspect
    {
        public string Name { get; set; }
        public double Amplifier {  get; set; }

        public Aspect(string name, double amp) 
        {
            Name = name;
            Amplifier = amp;
        }
    }
}
