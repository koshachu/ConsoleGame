using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Entities
{
    public class Player
    {
        public int Health = 100;


        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void Attack(Enemy enemy)
        {
            enemy.TakeDamage(GetDamage());
        }

        private int GetDamage()
        {
            return 10;
        }
        
    }

}
