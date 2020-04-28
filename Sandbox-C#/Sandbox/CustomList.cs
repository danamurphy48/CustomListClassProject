using System;
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
        public int Capacity { get { return capacity; } } //set capacity is valuable and make it large like 400

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
                    throw new IndexOutOfRangeException();//use this for string: ArgumentOutOfRangeException
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
            items[count] = item;
            count++;
            //if statement for when capacity exceeds 4
        }
        public bool Remove(T item)
        {
            return false;
        }
    }
}
