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

    public class HumanTests
    {
        Human Ting = new Human();

        [TestMethod()]
        public void HumanTest()
        {

          
            Assert.AreEqual(2, Ting.NumLegs);
            Assert.AreEqual(false, Ting.HasFur);
            Assert.AreEqual("Homosapien", Ting.Species);
            Assert.AreEqual(false, Ting.HasTail);
            Assert.AreEqual(true, Ting.HasOpposableThumb);
            Assert.AreEqual('S', Ting.MaritalStatus);
        }

        [TestMethod()]
        public void GetMarriedTest()
        {
            Assert.AreEqual('S', Ting.MaritalStatus);

            Ting.GetMarried();
            Assert.AreEqual('M', Ting.MaritalStatus);


        }

        [TestMethod()]
        public void GetMarriedTest1()
        {
            Assert.AreEqual(null, Ting.FirstName);
            Assert.AreEqual(null, Ting.LastName);

            Ting.FirstName = "Sau";
            Ting.LastName = "Married";
            Assert.AreEqual("Sau", Ting.FirstName);
            Assert.AreEqual("Married", Ting.LastName);
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            Ting.GetMarried();
            Assert.AreEqual('M', Ting.MaritalStatus);
            Ting.GetSingle();
            Assert.AreEqual('S', Ting.MaritalStatus);

        }

        [TestMethod()]
        public void GetSingleTest1()
        {
            Assert.AreEqual(null, Ting.FirstName);
            Assert.AreEqual(null, Ting.FirstName);
            Ting.FirstName = "Sau";
            Ting.LastName = "Kong";
            Assert.AreEqual("Sau", Ting.FirstName);
            Assert.AreEqual("Kong", Ting.LastName);



        }
    }
}