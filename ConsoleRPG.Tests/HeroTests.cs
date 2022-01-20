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
		public void WarriorHero_WarriorCreation_WarriorCreatedWithProperDefaultAttributes()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 5, Dexterity = 2, Intelligence = 1 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void MageHero_MageCreation_MageCreatedWithProperDefaultAttributes()
		{
			// Arrange
			MageHero testHero = new MageHero("testName");
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 1, Dexterity = 1, Intelligence = 8 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void RangerHero_RangerCreation_RangerCreatedWithProperDefaultAttributes()
		{
			// Arrange
			RangerHero testHero = new RangerHero("testName");
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 1, Dexterity = 7, Intelligence = 1 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void RogueHero_RogueCreation_RogueCreatedWithProperDefaultAttributes()
		{
			// Arrange
			RogueHero testHero = new RogueHero("testName");
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 2, Dexterity = 6, Intelligence = 1 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void AttributeGain_WarriorLevelsUp_WarriorGainsCorrectAmountOfAttributesOnLevelUp()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			testHero.LevelUp();
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 8, Dexterity = 4, Intelligence = 2 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void AttributeGain_MageLevelsUp_MageGainsCorrectAmountOfAttributesOnLevelUp()
		{
			// Arrange
			MageHero testHero = new MageHero("testName");
			testHero.LevelUp();
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 2, Dexterity = 2, Intelligence = 13 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void AttributeGain_RangerLevelsUp_RangerGainsCorrectAmountOfAttributesOnLevelUp()
		{
			// Arrange
			RangerHero testHero = new RangerHero("testName");
			testHero.LevelUp();
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 2, Dexterity = 12, Intelligence = 2 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void AttributeGain_RogueLevelsUp_RogueGainsCorrectAmountOfAttributesOnLevelUp()
		{
			// Arrange
			RogueHero testHero = new RogueHero("testName");
			testHero.LevelUp();
			PrimaryAttributes expected = new PrimaryAttributes() { Strength = 3, Dexterity = 10, Intelligence = 2 };
			
			// Act
			PrimaryAttributes actual = testHero.TotalPrimaryAttributes;
			
			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
