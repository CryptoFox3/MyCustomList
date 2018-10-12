using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTests
{
  
    [TestClass]
    public class MyListTestToString
    {
        public MyListTestToString()
        {
            //
            // TODO: Add constructor logic here
            //
        }

     
        [TestMethod]
        public void OneElementToString()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(123);

            string actual = myList.ToString();

            Assert.AreEqual("123", actual);
        }

        [TestMethod]
        public void TwoElementsToString()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(123);
            myList.Add(5);

            string actual = myList.ToString();

            Assert.AreEqual("123, 5", actual);
        }

        [TestMethod]
        public void AddMultipleIntExpectMultipleStringTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            string expected = "7";
            string actual;
            // Act
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            // Assert
            actual = myList[2].ToString();
            Assert.AreEqual(expected, actual); //CHECK LAST INDEX
        }

        [TestMethod]
        public void BoolToString()
        {
            MyList<bool> myList = new MyList<bool>();
            myList.Add(false);
        

            string actual = myList.ToString();

            Assert.AreEqual("False", actual);
        }
    }
}
