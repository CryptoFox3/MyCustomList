using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {

        public T[] array { get; set; }
        //public T[] newArray { get; set; }
        public int arrayPosition { get; set; }
        public int arrayCapacity { get; set; }
        public T this[int i] { get { return array[i];} set { array[i] = value; }}
        public MyList()
        {
            arrayCapacity = 5;
            arrayPosition = 0;
            array = new T[arrayCapacity];
        }
        

        public void Add(T itemToAdd)
        {
            if (arrayCapacity >= arrayPosition)
            {
                arrayCapacity += 5;
                T[] newArray = new T[arrayCapacity];

                for (int i = 0; i < arrayPosition; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[arrayPosition] = itemToAdd;
            arrayCapacity++;
        }
   }

        //static void Read()
        //{
       // foreach(string value in array[])
        //    {

  
        //    }
        //}
    }

