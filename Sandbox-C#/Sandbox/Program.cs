using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
            numbers.Remove(4); //2 6 8 10
            numbers[0] = 50;
            int number = numbers[2];
            //"26810"
            string result = numbers.ToString();

            CustomList<int> array1 = new CustomList<int>() { 1, 3, 5 };
            array1.Add(1);
            array1.Add(3);
            array1.Add(5);
            //string result = array1.ToString();
            CustomList<int> array2 = new CustomList<int>() { 2, 4, 6 };
            array2.Add(2);
            array2.Add(4);
            array2.Add(6);
            // string result = array2.ToString();
            CustomList<int> array3 = array1 + array2;
        }
    }
}

































/////////////////////////////////////////////////////////////
// Null Operators stuff

// nullable variables // ?
// new data type, can be used for parameters and method returns


// null-coalescing // ??
// int? number = null
// int age = number ?? 10;

// null-conditional // ?.
// int? queue = studnets?.Count;
// Student firstInLine = students?[0];

// ternary


/////////////////////////////////////////////////////////////