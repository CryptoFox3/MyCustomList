using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTests
{

    [TestClass]
    public class MyListTestRemoveOverload
    {
        public MyListTestRemoveOverload()
        {
  
 
        }

        [TestMethod]
        public void TestRemoveOverloadOneElement()
        {
            MyList<int> myListOne = new MyList<int>();
            MyList<int> myListTwo = new MyList<int>();
            myListOne.Add(1);
            myListTwo.Add(1);

            MyList<int> actual = myListOne - myListTwo;

            Assert.AreEqual(0, actual.Count());
        }
    }
}
