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
        public int arrayCount { get; set; }
        public int arrayCapacity { get; set; }
        public T this[int i] { get { return array[i];} set { array[i] = value; }}
        public MyList()
        {
            arrayCapacity = 5;
            arrayCount = 0;
            array = new T[arrayCapacity];
        }
        

        public void Add(T itemToAdd)
        {

            array[arrayCount] = itemToAdd;
            arrayCount++;
            CheckCapacity();

        }

        public void CheckCapacity()
        {
            if (arrayCount == arrayCapacity)
            {
                arrayCapacity += 5;
                T[] newArray = new T[arrayCapacity];

                for (int i = 0; i < arrayCount; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }


        }
        public void Remove(T itemToRemove)
        {

            for (int i = 0; i < arrayCapacity; i++)
            {
                if (array[i].Equals(itemToRemove))
                {
                //array[i] = 0;
                }
                else
                {
                    //Did not find matching valu
                }

            }


            
       
        }

        public void ShiftArray()
        {


        }

    }


   

        //static void Read()
        //{
       // foreach(string value in array[])
        //    {

  
        //    }
        //}
    }

