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
        private T[] capacity;
        private T[] count;

        // constructor (SPAWNER)
        public CustomList()
        {
            items = new T[4];
        }

        // member methods (CAN DO)
        public void Add(T item)
        {

        }
        public bool Remove(T item)
        {
            return false;
        }
    }
}
