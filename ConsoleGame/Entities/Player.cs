using ConsoleGame.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.Entities
{
    public class Player
    {
        private const int baseHealth = 100;
        private const int baseDamage = 1;

        public CharacterClass PlayerClass;

        private int strength;
        public int Strength
        {
            get { return strength; }
        }

        private int intelligence;
        public int Intelligence
        {
            get { return intelligence; }
        }

        private int constitution;
        public int Constitution
        {
            get { return constitution; }
        }

        private int health;

        public Player(CharacterClass charClass)
        {
            
            PlayerClass = charClass;

            GenerateStats();
            InitHealth();
            PrintStats();
        }

        private void InitHealth()
        {
            Health = Constitution * baseHealth;
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                Console.WriteLine("Player's health is " + health);
            }
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
            enemy.TakeDamage(Damage);

        }

        private int Damage
        {
            get
            {
                return baseDamage * Strength;
            }
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
