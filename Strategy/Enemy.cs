using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Enemy
    {
        public string _name = "Неизвестный";
        public int _hp = 1;
        public int _damage = 0;
        public Enemy(string name, int damage, int hp)
        {
            _damage = damage;
            _name = name;
            _hp = hp;
        }
        public void HitPlayer(Player player)
        {
            Random chance = new Random();
            if (chance.Next(0,11) >= 5)
            {
                player._hp -= _damage;
                if (player._hp > 0)
                {
                    Console.WriteLine($"{_name} нанёс игроку {_damage} урона! Осталось {player._hp} здоровья!");
                }
                else Events.PlayerKilled(player,this);
            }
            else Console.WriteLine($"{_name} промахнулся!");
        }
    }
}
