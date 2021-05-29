using ConsoleGame.Entities;
using ConsoleGame.Enums;
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
            var player = new Player(CharacterClass.Warrior);

            var enemy = new Enemy();           

            while (player.IsAlive && enemy.IsAlive)
            {
                player.Attack(enemy);

                if (!enemy.IsAlive)
                {
                    Console.WriteLine("Player won");
                    return; 
                }

                enemy.Attack(player);
                
                if (!player.IsAlive)
                {
                    Console.WriteLine("Enemy won");
                    return;
                }

            }
        }
    }

    
}
