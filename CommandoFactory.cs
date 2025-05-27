using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comando.commandos;

namespace Comando
{
    public class CommandoFactory
    {
        public List<Commando> ListCommandos = new List<Commando>();

        private void CreateComammando(string name,string codename,string status)
        {
            Commando commando = new Commando(name, codename, status);
            ListCommandos.Add(commando);
        }
        private void CreateAircimmando(string name, string codename,string status)
        {
            AirComando aircommando = new AirComando(name, codename, status);
            ListCommandos.Add(aircommando);
        }
        private void CreateSeacommando(string name,string codename,string status)
        {
            SeaCommando seaCommando = new SeaCommando(name, codename, status);
        }
        public void WhitchCommando(string TypeCommando,string name,string codename,string status)
        {
            switch (TypeCommando)
            {
                case "Rugul":
                    break;
                    CreateComammando(name,codename,status);
                case "Air":
                    CreateAircimmando(name, codename, status);
                    break;
                case "Sae":
                    break;
                default:
                    Console.WriteLine("The optgen is not");
                break;



            }
                
        }
    }
}
