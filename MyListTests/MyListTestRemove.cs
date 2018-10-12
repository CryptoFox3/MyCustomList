﻿using System;
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
       
        }


        [TestMethod]
        public void RemoveString()
        {
            // Arrange
            MyList<string> myList = new MyList<string>();
            int expected = 2;
            // Act
            myList.Add("Apple");
            myList.Add("Banana");
            myList.Add("Pear");


            // Assert
            bool actual = myList.Remove("Banana");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveItemInListExpectTrue()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            bool expected = true;
            // Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);


            // Assert
            int actual = myList.ArrayCount;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemExpectArrayToShiftCorrectly()
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

        public void OneElementRemoveTwoElements()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            int expectedCount = 9;
            // Act
            myList.Add(5);
          
            myList.Remove(9);
            myList.Remove(5);

            // Assert
            int actualCount = myList.Array[0];
            Assert.AreEqual(expectedCount, actualCount);
        }


    }
}
