using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando
{
    public class Enemy
    {
        public string Name;
        public int Live = 100;
        public bool Status;
        
        
        public Enemy(string name,bool status)
        {
            this.Name = name;
            this.Status = status;
            Console.WriteLine("I am a enemy");

        }

    }

}
