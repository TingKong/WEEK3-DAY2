﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Tests
{
    [TestClass()]
    public class MammalTests
    {
        Mammal Toast = new Mammal();

        [TestMethod()]
        public void MammalTest()
        {
            Toast.NumLegs = 4;
            Toast.HasOffspring = true;
            Toast.HasFur = false;
            Toast.HasTail = true;
            Assert.AreEqual(4, Toast.NumLegs);
            Assert.AreEqual(true, Toast.HasOffspring);
            Assert.AreEqual(false, Toast.HasFur);
            Assert.AreEqual(true, Toast.HasTail); Assert.AreEqual(true, Toast.GivesLiveBirth);
            Assert.AreEqual(0, Toast.NumChildren);
        }

        [TestMethod()]
        public void GiveBirthTest()
        {
            Toast.GiveBirth();
            Assert.IsTrue(Toast.HasOffspring);
            Assert.AreEqual(1, Toast.NumChildren);
        }

        [TestMethod()]
        public void GiveBirthTest1()
        {
            Toast.GiveBirth(2);
            Assert.IsTrue(Toast.HasOffspring);
            Assert.AreEqual(2, Toast.NumChildren);
        }
    }
}