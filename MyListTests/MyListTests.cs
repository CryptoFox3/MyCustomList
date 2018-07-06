using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Tests
{
    [TestClass()]
    public class MyListTests
    {
      
        [TestMethod]
        public void AddSixItemsExpectLastIndexTest()
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
        public void AddItemsCheckCountTest()
        {
            MyList<int> myList = new MyList<int>();
            int expectedCount = 3;
            myList.Add(5);
            myList.Add(7);
            myList.Add(8);

            int actualCount = myList.arrayCount;
            Assert.AreEqual(expectedCount, actualCount);


        }

        [TestMethod]
        public void RemoveSingleItemExpectTwoCountTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            int expectedCount = 2;
            // Act
            myList.Add(5);
            myList.Add(9);
            myList.Add(4);
            myList.Remove(9);

            // Assert
            int actualCount = myList.arrayCount;
            Assert.AreEqual(expectedCount, actualCount);
        } 
        [TestMethod]
        public void RemoveItemNotInListExpectNoChangeTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            int expectedCount = 3;
            // Act
            myList.Add(5);
            myList.Add(9);
            myList.Add(4);
            myList.Remove(1999);

            // Assert
            int actualCount = myList.arrayCount;
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void RemoveItemNotInListExpectFalseTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            bool expected = false;
            // Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            

            // Assert
            bool actual = myList.Remove(4);
            Assert.AreEqual(expected, actual);
        }[TestMethod]
        public void RemoveItemInListExpectTrueTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            bool expected = true;
            // Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);


            // Assert
            bool actual = myList.Remove(3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemExpectArrayToShiftCorrectlyTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            int expectedCount = 9;
            // Act
            myList.Add(5);
            myList.Add(9);
            myList.Add(4);
            myList.Remove(5);

            // Assert
            int actualCount = myList.array[0];
            Assert.AreEqual(expectedCount, actualCount);
        }

    }
}