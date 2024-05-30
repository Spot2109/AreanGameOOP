using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class AspectList
    {
        private List<Aspect> list;

        public AspectList()
        {
            list = new List<Aspect>();
            Aspect a1 = new Aspect("Trundering", 0.2);
            Aspect a2 = new Aspect("Blazoning", 0.5);
            Aspect a3 = new Aspect("Luminating", 0.7);
            Aspect a4 = new Aspect("Searing", 0.3);
            Aspect a5 = new Aspect("Zephyrus", 0.6);
            Aspect a6 = new Aspect("Vortexing", 0.4);
            Aspect a7 = new Aspect("Thundering", 0.8);
            Aspect a8 = new Aspect("Flaring", 0.9);
            Aspect a9 = new Aspect("Glimmering", 0.1);
            Aspect a10 = new Aspect("Shivering", 0.25);
            Aspect a11 = new Aspect("Quaking", 0.75);

            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            list.Add(a4);
            list.Add(a5);
            list.Add(a6);
            list.Add(a7);
            list.Add(a8);
            list.Add(a9);
            list.Add(a10);
            list.Add(a11);
        }
        

        public Aspect getAspect()
        {
            AspectList a = new AspectList();
    
            Random rnd = new Random();
            Aspect temp = a.list[rnd.Next(0, list.Count - 1)];

            return temp;
        }
    }
}
