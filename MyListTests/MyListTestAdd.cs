﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Tests
{
    [TestClass]
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
        }

        [TestMethod]
        public void AddStringExpectStringTest()
        {
            // Arrange
            MyList<string> myList = new MyList<string>();
            string StringToAdd = "apple";
            // Act
            myList.Add(StringToAdd);
            // Assert
            Assert.AreEqual(StringToAdd, myList[0]); //CHECK LAST INDEX
        }


        [TestMethod]
        public void AddItemsCheckCountTest()
        {
            MyList<int> myList = new MyList<int>();
            int expectedCount = 3;
            myList.Add(5);
            myList.Add(7);
            myList.Add(8);

            int actualCount = myList.ArrayCount;
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
            int actualCount = myList.ArrayCount;
            Assert.AreEqual(expectedCount, actualCount);
        }

        

        [TestMethod]
        public void GetCountExpectThreeTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            int expected = 3;
            // Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);


            // Assert
            int actual = myList.Count();
            Assert.AreEqual(expected, actual);
        }
       

        




    }
}