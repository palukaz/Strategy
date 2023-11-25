using Strategy.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Главный герой", 20);
            Player anton = new Player("Антон", 50);
            Enemy enemy = new Enemy("Слабак", 5, 15);
            Enemy lox = new Enemy("Лох", 10, 20);
            anton.SetWeapon(new Sword());
            Events.StartGame(anton);
            Events.EnemyDuel(anton, lox);
            Console.ReadLine();
        }
    }
}
