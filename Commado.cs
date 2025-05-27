using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando
{
    public class Commado
    {
        public string Name;
        public string CodeName;
        public string[] ArryaTools;
        public string Status;
        public Commado(string name, string codename, string status)
        {
            this.Name = name;
            this.CodeName = codename;
            this.Status = status;
            this.ArryaTools = new string[] {"Hammer", "Chisel", "Rope", "Bag", "Bottle"};
            
        }

        public void Walk()
        {
            this.Status = "Walking";
            Console.WriteLine(Status);
        }

        public void Hide()
        { 
            this.Status = "Hiding";
            Console.WriteLine(Status);
        }
        public void Attack()
        {
            Console.WriteLine($"The commando named {this.Name} is attacking now");
        }
    }
}
