using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
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
                    ShiftArray(i);
                    return true;

                }
            }
            return false;
        }

        public void ShiftArray(int index)
        {
            T[] newArray = new T[ArrayCapacity];

            for (int i = index; i < ArrayCount; i++)
            {
            newArray[i] = Array[i + 1];
            }
            Array = newArray;

        }

        public override string ToString()
        {
          
            string stringArray= "";
            if (ArrayCount != 0)
            {
                for (int i = 0; i < ArrayCount; i++)
                    stringArray = Convert.ToString(Array[i]);
            }
            return stringArray;

          
        }




    }
}

