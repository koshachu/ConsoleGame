using ConsoleGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame
{
    public class Game
    {
        public void Start()
        {
            Console.WriteLine("Start");
            var player = new Player();
            var enemy = new Enemy();
            

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("Player's health is " + player.Health);
                Console.WriteLine("Enemy's health is " + enemy.Health);

                player.Attack(enemy);
                Console.WriteLine("Enemy's health is " + enemy.Health);

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("Player won");
                    return; 
                }

                enemy.Attack(player);
                Console.WriteLine("Player's health is " + player.Health);
                if (player.Health <= 0)
                {
                    Console.WriteLine("Enemy won");
                    return;
                }
                


            }
        }
    }

    
}
