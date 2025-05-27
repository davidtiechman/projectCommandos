using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando
{
    public class Commando
    {
        private string Name;
        public string CodeName { get; set; }
        public string[] ArryaTools = new string[] {"Hammer", "Chisel", "Rope", "Bag", "Bottle"};
        public string Status;
        public Commando(string name, string codename, string status)
        {
            this.Name = name;
            this.CodeName = codename;
            this.Status = status;
            
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
        public virtual void Attack()
        {
            Console.WriteLine($"The commando named {this.Name} is attacking now");
        }
        public void GetName()
        {
            Console.WriteLine(this.Name);
        }
        public void SetName(string newname)
        {
            this.Name = newname;
        }
        public void SayNane(string commanderRank)
        {
            if (commanderRank == "GENERAL") Console.WriteLine(this.Name);
            else if (commanderRank == "COLONEL") Console.WriteLine(this.CodeName);
            else  Console.WriteLine("The infromation is classified");
            
        }
    }

}
