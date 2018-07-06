using System;
using MyList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void AddMultipleIndexTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();

            // Act
            myList.Add(8);
            myList.Add(9);
            myList.Add(5);
            myList.Add(16);
            myList.Add(98);
            myList.Add(34);

            // Assert
            Assert.AreEqual(34, myList[5]); //CHECK LAST INDEX
            Console.WriteLine(myList[5]);
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
