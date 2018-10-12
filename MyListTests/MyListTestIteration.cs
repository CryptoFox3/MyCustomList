using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTests
{
    /// <summary>
    /// Summary description for MyListTestIndex
    /// </summary>
    [TestClass]
    public class MyListTestIndex
    {
        public MyListTestIndex()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void IterationOneElement()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            int actual = 0;

            foreach (int item in myList)
            {
                actual += item;
            }

            Assert.AreEqual(actual, 1);
        }

        [TestMethod]
        public void IterationTwoElements()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(5);
            myList.Add(10);
            int actual = 0;

            foreach (int item in myList)
            {
                actual += item;
            }

            Assert.AreEqual(actual, 15);
        }

        [TestMethod]
        public void IterationFiveElements()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            myList.Add(50);

            int actual = 0;

            foreach (int item in myList)
            {
                actual += item;
            }

            Assert.AreEqual(actual, 150);
        }

        [TestMethod]
        public void IterationTenElements()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            int actual = 0;

            foreach (int item in myList)
            {
                actual += item;
            }

            Assert.AreEqual(actual, 100);
        }
    }
}
