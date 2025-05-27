using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando.commandos
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codename, string status) : base (name, codename, status) { }
    public void Swimming()
        {
            Console.WriteLine("The seacommando is swimming");
        }
        public override void Attack()
        {
            Console.WriteLine($"The saecommando is attacking now");
        }
    }
}
