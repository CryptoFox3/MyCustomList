using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTests
{
    /// <summary>
    /// Summary description for MyListTestRemove
    /// </summary>
    [TestClass]
    public class MyListTestRemove
    {
        public MyListTestRemove()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
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
            int actualCount = myList.Array[0];
            Assert.AreEqual(expectedCount, actualCount);
        }

        public void RemoveExcess()
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
            int actualCount = myList.Array[0];
            Assert.AreEqual(expectedCount, actualCount);
        }

    }
}
