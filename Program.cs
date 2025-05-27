using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comando.commandos;

namespace Comando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Commando commando1 = new Commando("jon","2","Staneding");
            //commando1.GetName();
            //commando1.SetName("donald");
            //commando1.GetName();
            //commando1.SayNane("GENERAL");
            //Console.WriteLine(commando1.Name);
            //AirComando aircommando = new AirComando("a", "3", "staneding");
            //commando1.Attack();
            //aircommando.Attack();
            //Commando[] arryrcommandos = new[] { commando1, aircommando };
            //foreach (Commando comm in arryrcommandos)
            //{
            //comm.Attack();
            //}
            Enemy enemy1 = new Enemy("kooc", true);
            Console.WriteLine(enemy1.Live);
        }
    }
}
