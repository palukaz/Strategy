using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public static class Events
    {
        public static void StartGame(Player player)
        {
            if (player is null)
            {
                Console.WriteLine("Определите игрока!");
                return;
            }
            Console.WriteLine($"{player._name} входит в опасный мир...");
            Console.ReadKey(true);
        }
        public static void EnemyDuel(Player player,Enemy enemy)
        {
            Console.WriteLine($"На {player._name} нападает {enemy._name} и вызывает его на дуэль!");
            Console.ReadKey(true);
            player.Duel(enemy);
        }
        public static void PlayerDeath(Player player,Enemy enemy)
        {
            Console.WriteLine($"{player._name} погиб... Его убил {enemy._name}");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
