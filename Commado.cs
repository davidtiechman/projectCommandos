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
    }
}
