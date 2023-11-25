using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Player
    {
        public string _name;
        public int _hp;
        private IWeapon _weapon;
        public Player(string name, int hp)
        {
            _name = name;
            _hp = hp;
        }
        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void Attack(Enemy enemy)
        {
            if (_weapon is null)
            {
                Console.WriteLine("У вас нет оружия!");
                Events.PlayerKilled(this, enemy);
                return;
            }
            Console.WriteLine($"{_name} готовится нанести удар");
            _weapon.Hit(this,enemy);
        }
        public void Duel(Enemy enemy)
        {
            while(_hp > 0 && enemy._hp > 0)
            {
                Attack(enemy);
                Console.ReadKey(true);
                if (enemy._hp > 0)
                {
                    enemy.HitPlayer(this);
                    Console.ReadKey(true);
                }
                else break;
            } 
        }
    }
}
