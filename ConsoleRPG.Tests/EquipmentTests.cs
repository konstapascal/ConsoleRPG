using ConsoleRPG.Attributes;
using ConsoleRPG.Exceptions.CustomExceptions;
using ConsoleRPG.Hero.HeroClasses;
using ConsoleRPG.Inventory;
using ConsoleRPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleRPG.Tests
{
	public class EquipmentTests
	{
		#region Equipping high level items
		[Fact]
		public void EquipItem_HeroEquipsHighLevelWeapon_ShouldReturnInvalidWeaponException()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			WeaponItem testWeapon = new WeaponItem("testAxe", 2, Slots.SLOT_WEAPON, WeaponType.WEAPON_AXE, new WeaponAttributes { AttacksPerSecond = 1.1, BaseDamage = 7 });

			// Act and assert
			Assert.Throws<InvalidWeaponException>(() => testHero.EquipItem(testWeapon, Slots.SLOT_WEAPON));
		}

		[Fact]
		public void EquipItem_HeroEquipsHighLevelArmor_ShouldReturnInvalidArmorException()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			ArmorItem testArmor = new ArmorItem("testArmor", 2, Slots.SLOT_BODY, ArmorType.ARMOR_PLATE, new PrimaryAttributes { Strength = 1 });

			// Act and assert
			Assert.Throws<InvalidArmorException>(() => testHero.EquipItem(testArmor, Slots.SLOT_BODY));
		}
		#endregion

		#region Equipping wrong types of items
		[Fact]
		public void EquipItem_HeroEquipsWrongWeaponType_ShouldReturnInvalidWeaponException()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			WeaponItem testWeapon = new WeaponItem("testBow", 1, Slots.SLOT_WEAPON, WeaponType.WEAPON_BOW, new WeaponAttributes { AttacksPerSecond = 1.1, BaseDamage = 7 });

			// Act and assert
			Assert.Throws<InvalidWeaponException>(() => testHero.EquipItem(testWeapon, Slots.SLOT_WEAPON));
		}

		[Fact]
		public void EquipItem_HeroEquipsWrongArmorType_ShouldReturnInvalidWeaponException()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			ArmorItem testArmor = new ArmorItem("testArmor", 1, Slots.SLOT_BODY, ArmorType.ARMOR_CLOTH, new PrimaryAttributes { Strength = 1 });

			// Act and assert
			Assert.Throws<InvalidArmorException>(() => testHero.EquipItem(testArmor, Slots.SLOT_BODY));
		}
		#endregion

		#region Equipping valid items
		[Fact]
		public void EquipItem_HeroEquipsValidWeapon_ShouldReturnSuccessMessage()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			WeaponItem testWeapon = new WeaponItem("testAxe", 1, Slots.SLOT_WEAPON, WeaponType.WEAPON_AXE, new WeaponAttributes { AttacksPerSecond = 1.1, BaseDamage = 7 });
			string expected = "New weapon equipped!";

			// Act
			string actual = testHero.EquipItem(testWeapon, Slots.SLOT_WEAPON);
		
			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void EquipItem_HeroEquipsValidArmor_ShouldReturnSuccessMessage()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			ArmorItem testArmor = new ArmorItem("testArmor", 1, Slots.SLOT_BODY, ArmorType.ARMOR_PLATE, new PrimaryAttributes { Strength = 1 });
			string expected = "New armor equipped!";

			// Act
			string actual = testHero.EquipItem(testArmor, Slots.SLOT_BODY);

			// Assert
			Assert.Equal(expected, actual);
		}
		#endregion

		#region Calculating hero damage cases
		[Fact]
		public void Damage_HeroDamageWithoutAWeapon_ShouldDealCorrectAmountOfDamage()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			double expected = 1 * (1 + ((double) 5 / 100));

			// Act
			double actual = testHero.Damage;

			// Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Damage_HeroDamageWithAWeapon_ShouldDealCorrectAmountOfDamage()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			WeaponItem testWeapon = new WeaponItem("testAxe", 1, Slots.SLOT_WEAPON, WeaponType.WEAPON_AXE, new WeaponAttributes { AttacksPerSecond = 1.1, BaseDamage = 7 });
			testHero.EquipItem(testWeapon, Slots.SLOT_WEAPON);
			double expected = (7 * 1.1) * (1 + ((double) 5 / 100));

			// Act
			double actual = testHero.Damage;

			// Assert
			Assert.Equal(expected, actual);
		} 

		[Fact]
		public void Damage_HeroDamageWithAWeaponAndArmor_ShouldDealCorrectAmountOfDamage()
		{
			// Arrange
			WarriorHero testHero = new WarriorHero("testName");
			WeaponItem testWeapon = new WeaponItem("testAxe", 1, Slots.SLOT_WEAPON, WeaponType.WEAPON_AXE, new WeaponAttributes { AttacksPerSecond = 1.1, BaseDamage = 7 });
			ArmorItem testArmor = new ArmorItem("testArmor", 1, Slots.SLOT_BODY, ArmorType.ARMOR_PLATE, new PrimaryAttributes { Strength = 1 });
			testHero.EquipItem(testWeapon, Slots.SLOT_WEAPON);
			testHero.EquipItem(testArmor, Slots.SLOT_BODY);
			double expected = (7 * 1.1) * (1 + ((double) (5 + 1) / 100));

			// Act
			double actual = testHero.Damage;

			// Assert
			Assert.Equal(expected, actual);
		}
		#endregion
	}
}
