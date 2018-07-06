using System;
using MyList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void AddOneIndexTest()
        {
            // Arrange
            int itemToAdd = 9;
            MyList<int> myList = new MyList<int>();

            // Act
            myList.Add(itemToAdd);

            // Assert
            Assert.AreEqual(itemToAdd, myList[0]);
            Console.WriteLine(myList[0]);
        }

        [TestMethod]
        public void ArrayCountTest()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod4()
        {
        }
    }
}
