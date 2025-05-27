using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando
{
    public class EnemyFactory
    {
        List<Enemy> Listenemy = new List<Enemy>();

        public void CreateEnemy(string name, bool status)
        {
            Enemy enemy = new Enemy(name, status);
            Listenemy.Add(enemy);
        }
    }
}
