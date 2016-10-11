using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(true, Toast.GivesLiveBirth);
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