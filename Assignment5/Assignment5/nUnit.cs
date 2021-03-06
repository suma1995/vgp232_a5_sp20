﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Assignment5
{
    [TestFixture]
    class nUnit
    {
        Item item1;
        Item item2;
        Item item3;
        Character mCharacter1;
        Character mCharacter2;
        Character mCharacter3;
        Character mCharacter4;
        Character mCharacter5;
        Inventory inventory;

        [Test]
        public void itemsTest()
        {
            Item item1 = new Item("Angus", 3, ItemType.consumable);
            Item item2 = new Item("Li", 4, ItemType.equipment);
            Item item3 = new Item("Mars", 5, ItemType.key);
            item1.Show();
            item2.Show();
            item3.Show();
            string expectedName1 = "Angus";
            string expectedName2 = "Li";
            string expectedName3 = "Mars";

            int expectedModifier1 = 3;
            int expectedModifier2 = 4;
            int expectedModifier3 = 5;

            ItemType expectedType1 = ItemType.consumable;
            ItemType expectedType2 = ItemType.equipment;
            ItemType expectedType3 = ItemType.key;

            Assert.AreEqual(expectedName1, item1.Name);
            Assert.AreEqual(expectedName2, item2.Name);
            Assert.AreEqual(expectedName3, item3.Name);

            Assert.AreEqual(expectedModifier1, item1.Modifier);
            Assert.AreEqual(expectedModifier2, item2.Modifier);
            Assert.AreEqual(expectedModifier3, item3.Modifier);

            Assert.AreEqual(expectedType1, item1.IType);
            Assert.AreEqual(expectedType2, item2.IType);
            Assert.AreEqual(expectedType3, item3.IType);
        }

        public void CharacterTest()
        {
            //mCharacter1 = new Character("Angus",RaceCatagory.Dwarf,100);
            //mCharacter2 = new Character("Angus",RaceCatagory.Elf,200);
            mCharacter3 = new Character("Angus",RaceCatagory.Human,300);
            //mCharacter4 = new Character("Angus",RaceCatagory.Orc,400);
            //mCharacter5 = new Character("Angus",RaceCatagory.Undead,500);

            //string exexpectedName1 = "Angus";
            //string exexpectedName2 = "Angus";
            string exexpectedName3 = "Angus";
            //string exexpectedName4 = "Angus";
            //string exexpectedName5 = "Angus";

            //RaceCatagory expected1 = RaceCatagory.Dwarf;
            //RaceCatagory expected2 = RaceCatagory.Elf;
            RaceCatagory expected3 = RaceCatagory.Human;
            //RaceCatagory expected4 = RaceCatagory.Orc;
            //RaceCatagory expected5 = RaceCatagory.Undead;

            //int expectedHealthPoints1 = 100;
            //int expectedHealthPoints2 = 200;
            int expectedHealthPoints3 = 300;
            //int expectedHealthPoints4 = 400;
            //int expectedHealthPoints5 = 500;

            //Assert.AreEqual(exexpectedName1, mCharacter1.Name);
            //Assert.AreEqual(exexpectedName2, mCharacter2.Name);
            Assert.AreEqual(exexpectedName3, mCharacter3.Name);
            //Assert.AreEqual(exexpectedName4, mCharacter4.Name);
            //Assert.AreEqual(exexpectedName5, mCharacter5.Name);

            //Assert.AreEqual(expected1, mCharacter1.Race);
            //Assert.AreEqual(expected2, mCharacter2.Race);
            Assert.AreEqual(expected3, mCharacter3.Race);
            //Assert.AreEqual(expected4, mCharacter4.Race);
            //Assert.AreEqual(expected5, mCharacter5.Race);

            //Assert.AreEqual(expectedHealthPoints1, mCharacter1.HealthPoints);
            //Assert.AreEqual(expectedHealthPoints2, mCharacter2.HealthPoints);
            Assert.AreEqual(expectedHealthPoints3, mCharacter3.HealthPoints);
            //Assert.AreEqual(expectedHealthPoints4, mCharacter4.HealthPoints);
            //Assert.AreEqual(expectedHealthPoints5, mCharacter5.HealthPoints);

            //mCharacter1.TakeDamage(1);
            //int actualAfterDamg1 = mCharacter1.HealthPoints;
            //int expectedAfterDamg1 = 99;
            //Assert.AreEqual(expectedAfterDamg1, actualAfterDamg1);

            //mCharacter2.TakeDamage(100);
            //int actualAfterDamg2 = mCharacter2.HealthPoints;
            //int expectedAfterDamg2 = 100;
            //Assert.AreEqual(expectedAfterDamg2, actualAfterDamg2);

            mCharacter3.TakeDamage(100);
            int actualAfterDamg3 = mCharacter3.HealthPoints;
            int expectedAfterDamg3 = 200;
            Assert.AreEqual(expectedAfterDamg3, actualAfterDamg3);

            //mCharacter4.TakeDamage(10);
            //int actualAfterDamg4 = mCharacter4.HealthPoints;
            //int expectedAfterDamg4 = 390;
            //Assert.AreEqual(expectedAfterDamg4, actualAfterDamg4);

            //mCharacter5.TakeDamage(0);
            //int actualAfterDamg5 = mCharacter5.HealthPoints;
            //int expectedAfterDamg5 = 500;
            //Assert.AreEqual(expectedAfterDamg5, actualAfterDamg5);

            //mCharacter1.RestoreHealth(1);
            //int actualAfterHeal1 = mCharacter1.HealthPoints;
            //int expectedAfterHeal1 = 101;
            //Assert.AreEqual(expectedAfterHeal1, actualAfterHeal1);

            //mCharacter2.RestoreHealth(100);
            //int actualAfterHeal2 = mCharacter2.HealthPoints;
            //int expectedAfterHeal2 = 300;
            //Assert.AreEqual(expectedAfterHeal2, actualAfterHeal2);

            mCharacter3.RestoreHealth(100);
            int actualAfterHeal3 = mCharacter3.HealthPoints;
            int expectedAfterHeal3 = 400;
            Assert.AreEqual(expectedAfterHeal3, actualAfterHeal3);

            //mCharacter4.RestoreHealth(10);
            //int actualAfterHeal4 = mCharacter4.HealthPoints;
            //int expectedAfterHeal4 = 410;
            //Assert.AreEqual(expectedAfterHeal4, actualAfterHeal4);

            //mCharacter5.RestoreHealth(0);
            //int actualAfterHeal5 = mCharacter5.HealthPoints;
            //int expectedAfterHeal5 = 500;
            //Assert.AreEqual(expectedAfterHeal5, actualAfterHeal5);
        }


    }

}
