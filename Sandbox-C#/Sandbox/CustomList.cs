﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } } //set capacity is valuable and make it large like 400

        public T this[int index]    //middleman to get into array
        {
            get
            {
                if (index < count && index >=0)
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
                T[] tempArray = new T[capacity*=2];

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


            //if statement for when capacity exceeds 4
        }
        public bool Remove(T item)
        {
            return false;
        }
    }
}
