using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTests
{

    [TestClass]
    public class MyListTestAddOverload
    {
        public MyListTestAddOverload()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void TwoIntElementsOverload()
        {

            MyList<int> myListOne = new MyList<int>();
            MyList<int> myListTwo = new MyList<int>();
            myListOne.Add(5);
            myListTwo.Add(5);

            MyList<int> actual = myListOne + myListTwo;

            Assert.AreEqual(myListOne.Array[0], actual.Array[0]);
            Assert.AreEqual(myListOne.Array[0], actual.Array[1]);
        }

        [TestMethod]
        public void TwoStringElementsOverload()
        {

            MyList<string> myListOne = new MyList<string>();
            MyList<string> myListTwo = new MyList<string>();
            myListOne.Add("5");
            myListTwo.Add("5");

            MyList<string> actual = myListOne + myListTwo;

            Assert.AreEqual(myListOne.Array[0], actual.Array[0]);
            Assert.AreEqual(myListOne.Array[0], actual.Array[1]);
        }
    }
}
