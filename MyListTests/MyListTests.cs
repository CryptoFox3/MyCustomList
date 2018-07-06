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
        [TestMethod()]
        public void test ()
        {
            Assert.Fail();
        }
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
            MyList<int> myList = new MyList<int>();
            int expectedCount = 3;
            myList.Add(5);
            myList.Add(7);
            myList.Add(8);

            int actualCount = myList.arrayCount;
            Assert.AreEqual(expectedCount, actualCount);


        }

        [TestMethod]
        public void ItemRemoveTest()
        {
            // Arrange
            MyList<int> myList = new MyList<int>();
            myList.Add(5);
            myList.Add(9);


            // Act

            // Assert



        }

    }
}