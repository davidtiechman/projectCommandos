using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.commandos
{
    public class AirComando : Commando
    {
        public AirComando(string name, string codename, string status) :base(name, codename, status) { }

        public void Parachuting()
        {
            Console.WriteLine("The aircommando is parachuting");
        }
        public override void Attack()
        {
            Console.WriteLine($"The aircommando named is attacking now");
        }

    }
}
