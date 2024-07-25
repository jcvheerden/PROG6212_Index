using DoggyDayCare_Icetask1;

namespace DoggyDayCare_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Doggo dog = new Doggo(6, 10, 001, "Maltese Poodle", "Snuggles");
            Assert.AreEqual(dog[0], 6);

        }

        [TestMethod]
        public void updateWeightTest()
        {

            Doggo dog = new Doggo(6, 10, 001, "Maltese Poodle", "Snuggles");
            dog[1] = 12;

            Assert.AreEqual(dog[1], 12);

        }

        [TestMethod]
        public void testBreed()
        {

            Doggo dog = new Doggo(6, 10, 001, "Maltese Poodle", "Snuggles");
            Assert.AreEqual(dog[3], "Maltese Poodle");

        }

        [TestMethod]
        public void testKennel()
        {

            Doggo dog = new Doggo(6, 10, 001, "Maltese Poodle", "Snuggles");
            Assert.AreEqual(dog[2], 001);

        }

        [TestMethod]
        public void updateAge()
        {

            Doggo dog = new Doggo(6, 10, 001, "Maltese Poodle", "Snuggles");
            dog[0] = 5;

            Assert.AreEqual(dog[0], 5);

        }

    }
}




