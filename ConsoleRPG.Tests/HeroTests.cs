using ConsoleRPG.Attributes;
using ConsoleRPG.Hero.HeroClasses;
using System;
using Xunit;

namespace ConsoleRPG.Tests
{
	public class HeroTests
	{
		[Fact]
		public void Hero_HeroCreation_HeroShouldBeLevelOne()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			int expected = 1;
			// Act
			int actual = testHero.Level;
			// Assert
			Assert.Equal(expected, actual);
		}
		[Fact]
		public void LevelUp_HeroLevelsUp_HeroShouldBeLevelTwo()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			testHero.LevelUp();
			int expected = 2;
			// Act
			int actual = testHero.Level;
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Hero_HeroCreation_HeroCreatedWithProperDefaultAttributes()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 5, Dexterity = 2, Intelligence = 1 };
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
