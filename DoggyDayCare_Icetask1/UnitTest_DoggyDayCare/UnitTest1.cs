using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoggyDayCare_Icetask1;
using System;

//this.age = age;
//this.dogWeight = dogWeight;
//this.dogBreed = dogBreed;
//this.dogName = dogName;
//this.dogKennel = dogKennel;

namespace UnitTest_DoggyDayCare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAge()
        {

            Doggo dog = new Doggo(6, 10, "Maltese Poodle", "Snuggles", 001);
            Assert.AreEqual(dog[0], 6);

        }

        [TestMethod]
        public void updateWeightTest()
        {

            Doggo dog = new Doggo(6, 10, "Maltese Poodle", "Snuggles", 001);
            dog[1] = 12;

            Assert.AreEqual(dog[1], 12);

        }

        [TestMethod]
        public void testBreed()
        {

            Doggo dog = new Doggo(6, 10, "Maltese Poodle", "Snuggles", 001);
            Assert.AreEqual(dog[2], "Maltese Poodle");

        }

        [TestMethod]
        public void testKennel()
        {

            Doggo dog = new Doggo(6, 10, "Maltese Poodle", "Snuggles", 001);
            Assert.AreEqual(dog[4], 001);

        }

        [TestMethod]
        public void updateAge()
        {

            Doggo dog = new Doggo(6, 10, "Maltese Poodle", "Snuggles", 001);
            dog[0] = 5;

            Assert.AreEqual(dog[0], 5);

        }



    }
}
