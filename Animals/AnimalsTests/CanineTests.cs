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
            //NumLegs = 4;
            //HasFur = true;
            //Species = "Canis";
            //HasTail = true;
            //HasOpposableThumb = false;

            

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
