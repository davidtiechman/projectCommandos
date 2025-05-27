using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando
{
    public class Weapon
    {
        public string Name;
        public string Menufacturer;
        public int NumBolls;

        public Weapon(string name, string menufacturer,int numbllle)
        {
            this.Name = name;
            this.Menufacturer = menufacturer;
            this.NumBolls = numbllle;
        }
        public void Shoot()
        {
            Console.WriteLine($"The {this.Name} fired");
            this.NumBolls -= 1;
        }
    }
}
