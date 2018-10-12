using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTests
{
    [TestClass]
    public class MyListTestZipper
    {
        [TestMethod]
        public void ZipperTwoStringLists()
        {
            // Arrange
            MyList<string> myListOne = new MyList<string>();
            MyList<string> myListTwo = new MyList<string>();
            
            // Act
            myListOne.Add("x");
            myListOne.Add("y");
            myListOne.Add("z");
            myListTwo.Add("a");
            myListTwo.Add("b");
            myListTwo.Add("c");

            MyList<string> MyListThree = myListOne.Zip(myListTwo);


            // Assert
            Assert.AreEqual(MyListThree[0], "x");
            Assert.AreEqual(MyListThree[1], "a");
            Assert.AreEqual(MyListThree[2], "y");
            Assert.AreEqual(MyListThree[3], "b");
            Assert.AreEqual(MyListThree[4], "z");
            Assert.AreEqual(MyListThree[5], "c");
        }
        public void ZipperTwoUnevenStringLists()
        {
            // Arrange
            MyList<string> myListOne = new MyList<string>();
            MyList<string> myListTwo = new MyList<string>();

            // Act
            myListOne.Add("x");
            myListOne.Add("y");
            myListOne.Add("z");
            myListTwo.Add("a");
            myListTwo.Add("b");
           

            MyList<string> MyListThree = myListOne.Zip(myListTwo);


            // Assert
            Assert.AreEqual(MyListThree[0], "x");
            Assert.AreEqual(MyListThree[1], "a");
            Assert.AreEqual(MyListThree[2], "y");
            Assert.AreEqual(MyListThree[3], "b");
            Assert.AreEqual(MyListThree[4], "z");
           
        }

        [TestMethod]
        public void ZipperTwoIntLists()
        {
            // Arrange
            MyList<int> myListOne = new MyList<int>();
            MyList<int> myListTwo = new MyList<int>();
            
            // Act
            myListOne.Add(1);
            myListOne.Add(2);
            myListOne.Add(3);
            myListTwo.Add(4);
            myListTwo.Add(5);
            myListTwo.Add(6);

            MyList<int> MyListThree = myListOne.Zip(myListTwo);


            // Assert
            Assert.AreEqual(MyListThree[0], 1);
            Assert.AreEqual(MyListThree[1], 4);
            Assert.AreEqual(MyListThree[2], 2);
            Assert.AreEqual(MyListThree[3], 5);
            Assert.AreEqual(MyListThree[4], 3);
            Assert.AreEqual(MyListThree[5], 6);
        }

        [TestMethod]
        public void ZipperBoolLists()
        {
            MyList<bool> myListOne = new MyList<bool>();
            MyList<bool> myListTwo = new MyList<bool>();
            myListOne.Add(true);
            myListOne.Add(true);
            myListOne.Add(true);
            myListTwo.Add(false);
            myListTwo.Add(false);
            myListTwo.Add(false);

            MyList<bool> myListThree = myListOne.Zip(myListTwo);

            Assert.AreEqual(myListThree[0], true);
            Assert.AreEqual(myListThree[1], false);
            Assert.AreEqual(myListThree[2], true);
            Assert.AreEqual(myListThree[3], false);
            Assert.AreEqual(myListThree[4], true);
            Assert.AreEqual(myListThree[5], false);
        }
    }
}
