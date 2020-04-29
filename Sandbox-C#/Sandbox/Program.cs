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
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
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