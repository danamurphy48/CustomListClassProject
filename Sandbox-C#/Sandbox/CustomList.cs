using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T> : IEnumerable
    {
        // member variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }

        public T this[int index]    //middleman to get into array
        {
            get
            {
                if (index < count && index >= 0)
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                items[index] = value;
            }
        }

        // constructor (SPAWNER)
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        // member methods (CAN DO)
        public void Add(T item)
        {
            if (capacity == count)
            {
                //0. Make array
                // 2. double capacity
                T[] tempArray = new T[capacity *= 2];

                //1. Copy array

                //int index = 0;
                //foreach (T itemInArray in items)
                //{
                //    tempArray[index] = itemInArray;
                //    index++;
                //}
                for (int itemInArray = 0; itemInArray < count; itemInArray++)
                {
                    tempArray[itemInArray] = items[itemInArray];
                }

                //3. add at next available index
                tempArray[count] = item;
                //4. reassign items array to tempArray
                items = tempArray;
            }
            else
            {
                items[count] = item;
            }
            count++;
        }
        public bool Remove(T item)
        {
            //1. read current array
            //T[] valueToRemove = new T[capacity];
            bool shiftValue = false;
            //2. find remove value 
            //manipulate items directly and loop
            for (int i = 0; i < count; i++) //this method copies latter value to preceding index but doesn't shift the rest
            {
                //if I haven't found item to remove yet
                //if item does equal value in items array
                //if we have found value to be "removed"
                if (item.Equals(items[i]))
                {
                    count--;
                    items[i] = items[i + 1];
                    shiftValue = true;
                }

                else if (shiftValue == true)
                {
                    items[i] = items[i + 1];
                }
            }
            return shiftValue;

            //build new array and use bool check
            //this method is just adding the value to remove instead of removing it
            //if (valueToRemove == items)//this doesn't work probably need to use above loop
            //{
            //    for (int valueInArray = 0; valueInArray < count; valueInArray--)
            //    {
            //        valueToRemove[valueInArray] = items[valueInArray];
            //        count--;
            //    }
            //    valueToRemove[count] = item;
            //    items = valueToRemove;
            //    return true;
            //}
            //else
            //{
            //    items[count] = item;
            //}
            //count--;

            //3. replace value with next index in line
            //4. shift array to move values by location of value to remove
            //5. don't need to decrease capacity probably
            //6. count--
        }


        public override string ToString()
        {
            //2 4 6 8
            //"2468"
            string result = "";
            for (int i = 0; i < count; i++)
            {

                result += items[i].ToString();
            }
            return result;
        }
         
        //ToString()
        //you are overriding C# ToString()
        //you can use .ToString() inside the method
        //    Console.WriteLine(result);
        //    return result;
        //    //1. needs to read contents of array -XX
        //    //2. needs to convert contents in array to string -- can use .ToString()
        //    //3. needs to return contents as a string in one line i.e., "26810"
            
        //    //"26810"
        //    //string result = numbers.ToString();

        public static CustomList<T> operator +(CustomList<T> array1, CustomList<T> array2)
        {
            CustomList<T> array3 = new CustomList<T>();
            for (int i = 0; i < array1.Count; i++)
            {
                array3.Add(array1[i]);
            }
            for (int i = 0; i < array2.Count; i++)
            {
                array3.Add(array2[i]);
            }
            return array3;
        }
        public CustomList<T> Zip(CustomList<T> array1, CustomList<T> array2)
        {
            //array1: 1 3 5
            //array2: 2 4 6
            //1 2 3 4 5 6
            CustomList<T> arrayLength;
            CustomList<T> array3 = new CustomList<T>();
            if (array1.Count >= array2.Count)
            {
                arrayLength = array1;
            }
            else
            {
                arrayLength = array2;
            }
            for (int i = 0; i < arrayLength.Count; i++)
            {
                array3.Add(array1[i]);
                array3.Add(array2[i]);
            }
            return array3;
        }
        public static CustomList<T> operator -(CustomList<T> array1, CustomList<T> array2)
        {
            CustomList<int> array3 = new CustomList<int>();
            array3.items = array1.items - array2.items;
            array3.count = array1.count - array2.count;
            array3.capacity = array1.capacity - array2.capacity;
            return numbers;
        }

        //public IEnumerable GetEnumerator()
        //{
            
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];

            }
        }
    }
}
