using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Entities
{
    public class Enemy
    {
        public Enemy()
        {
            Health = 100;
        }

        private int health;
        public int Health 
        { 
            get
            {
                return health;
            }
            set
            {
                health = value;
                Console.WriteLine("Enemy's health is " + health);
            }
        } 

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void Attack(Player player)
        {
            player.TakeDamage(GetDamage());
            
        }

        private int GetDamage()
        {
            return 10;
        }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
            
        }
    }
}
