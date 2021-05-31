using ConsoleGame.Entities;
using NUnit.Framework;

namespace ConsoleGameTests
{

    public class PlayerTests
    {
        private Player sut;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlayerStatsTest_CreateWarrior()
        {
            //arrange-act
            sut = new Player(ConsoleGame.Enums.CharacterClass.Warrior);

            //assert
            Assert.AreEqual(10, sut.Strength);
            Assert.AreEqual(5, sut.Intelligence);
            Assert.AreEqual(7, sut.Constitution);
        }
    }
}