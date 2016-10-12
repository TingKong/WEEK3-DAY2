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
    public class CanineTests
    {
        Canine Moo = new Canine();
        Human Ting = new Human();

        [TestMethod()]
        public void CanineTest()
        {
            Assert.AreEqual(4, Moo.NumLegs);
            Assert.IsTrue(  Moo.HasFur);
            Assert.AreEqual("Canis", Moo.Species);
            Assert.IsTrue( Moo.HasTail);
            Assert.IsFalse(Moo.HasOpposableThumb);
        }

       
        [TestMethod()]
        public void AdoptedTest()
        {
            Ting.FirstName = "Ting";
            Moo.Adopted(Ting);
            Assert.AreEqual(Ting.FirstName, Moo.Owner.FirstName);
        }

        [TestMethod()]
        public void AdoptedTest1()
        {
            Moo.DogName = "Moo";
            Moo.Adopted(Ting, "Dude");
            Assert.AreEqual("Dude", Moo.DogName);
            Assert.AreEqual(Ting, Moo.Owner);

        }
    }
}
