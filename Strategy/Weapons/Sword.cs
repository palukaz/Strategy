using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Weapons
{
    public class Sword : IWeapon
    {
        private static int _damage = 7;
        public Sword() 
        { 
        
        }
        public Sword(int boost) 
        {
            _damage += boost;
        }
        void IWeapon.Hit(Player player,Enemy enemy)
        {
            Random chance = new Random();
            if (chance.Next(0, 11) >= 5)
            {
                enemy._hp -= _damage;
                if (enemy._hp > 0)
                {
                   Console.WriteLine($"{player._name} нанес {enemy._name} {_damage} урона! У него осталось {enemy._hp} здоровья");
                }
                else Console.WriteLine($"{player._name} убил {enemy._name}, нанеся {_damage} урона");
            }
            else Console.WriteLine($"{player._name} промахнулся!");
        }
    }
    
}
