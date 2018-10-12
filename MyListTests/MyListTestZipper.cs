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
    }
}
