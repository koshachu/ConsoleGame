using ConsoleGame.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Entities
{
    public class Player
    {
        public int Health = 100;
        public CharacterClass PlayerClass;

        private int strength;
        private int intelligence;
        private int constitution;

        public Player(CharacterClass charClass)
        {
            PlayerClass = charClass;

            GenerateStats();
            PrintStats();
        }

        private void PrintStats()
        {
            Console.WriteLine($"strength = {strength}, intelligence = {intelligence}, constitution = {constitution}");
        }

        private void GenerateStats()
        {
            switch (PlayerClass)
            {
                case CharacterClass.Warrior:
                    strength = 10;
                    intelligence = 5;
                    constitution = 7;
                    break;
                case CharacterClass.Mage:
                    strength = 5;
                    intelligence = 10;
                    constitution = 4;
                    break;
                default:
                    Console.WriteLine("Character class must be chosen before");
                    break;
            }
        }

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
