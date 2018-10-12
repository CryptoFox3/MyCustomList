using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T> : IEnumerable
    {

        public T[] Array { get; set; }
        //public T[] newArray { get; set; }
        public int ArrayCount { get; set; }
        public int ArrayCapacity { get; set; }
        public T this[int i] { get { return Array[i];} set { Array[i] = value; }}

        public MyList()
        {
            ArrayCapacity = 5;
            ArrayCount = 0;
            Array = new T[ArrayCapacity];
        }
        

        public void Add(T itemToAdd)
        {

            Array[ArrayCount] = itemToAdd;
            ArrayCount++;
            CheckCapacity();

        }

        public void CheckCapacity()
        {
            if (ArrayCount == ArrayCapacity)
            {
                ArrayCapacity += 5;
                T[] newArray = new T[ArrayCapacity];

                for (int i = 0; i < ArrayCount; i++)
                {
                    newArray[i] = Array[i];
                }
                Array = newArray;
            }
        }
        public int Count()
        {
            return ArrayCount;
        }

        public bool Remove(T itemToRemove)
        {
 
            for (int i = 0; i < ArrayCount; i++)
            {
                if (Array[i].Equals(itemToRemove))
                {
                    ArrayCount--;
                    this.ShiftArray(i);
                    return true;

                }
            }
            return false;
        }

        public void ShiftArray(int index)
        {
            if (ArrayCount == 0)
            {
            T[] newArray = new T[ArrayCount];
                for (int i = 0; i < ArrayCount; i++)
                {
                    if (i != index)
                    {
                        newArray[i] = Array[i];
                    }

                }
                Array = newArray;
            }
            else if (index == 0 && ArrayCount == 2)
            {
                T[] newArray = new T[ArrayCount];
                for (int i = 0; i < ArrayCount + 1; i++)
                {
                    if (i > index)
                    {
                        newArray[i - 1] = Array[i];
                    }
                }
                Array = newArray;
            }
            else
            {
                T[] newArray = new T[ArrayCount];
                for (int i = 0; i < ArrayCount + 1; i++)
                {
                    if (i < index)
                    {
                        newArray[i] = Array[i];
                    }
                    else if (i > index)
                    {
                        newArray[i - 1] = Array[i];
                    }
                }
                Array = newArray;
            }

        }

        public override string ToString()
        {
          
            string stringArray = "";
            if (ArrayCount != 0)
            {
                for (int i = 0; i < ArrayCount; i++)
                    if (i == ArrayCount - 1)
                    {
                        stringArray += Convert.ToString(Array[i]);
                    }
                    else
                    {
                        stringArray += Convert.ToString(Array[i]) + ", ";
                    }
            }
            return stringArray;
        }

        public static MyList<T> operator +(MyList<T> firstList, MyList<T> secondList)
        {
            MyList<T> newArray = new MyList<T>();

            if (firstList.Count() != 0) {
                for (int i = 0; i < firstList.Count(); i++)
                {
                    newArray.Add(firstList[i]);
                }
            }
            if (secondList.Count() != 0) {
                for (int i = 0; i < secondList.Count(); i++)
                {
                    newArray.Add(secondList[i]);
                }
            }

            return newArray;
        }

           public static MyList<T> operator -(MyList<T> firstList, MyList<T> secondList)
        {
            for (int i = 0; i < firstList.Count(); i++)
            {
                for (int j = 0; j < secondList.Count(); j++)
                {
                    if (firstList.Array[i].Equals(secondList.Array[j]))
                    {
                        firstList.Remove(secondList.Array[j]);
                        i--;
                        break;
                    }
                }
            }

            return firstList;
        }

        public MyList<T> Zip(MyList<T> myListTwo)
        {
            MyList<T> myListThree = new MyList<T>();
            for (int i = 0; i < ArrayCount + myListTwo.Count(); i++)
            {
                if (ArrayCount > i)
                {
                    myListThree.Add(Array[i]);
                }
                if (myListTwo.Count() > i)
                {
                    myListThree.Add(myListTwo.Array[i]);
                }
            }
            return myListThree;
        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < ArrayCount; i++)
            {
                yield return Array[i];

            }
        }












    }
}

