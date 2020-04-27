using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_AddingMultipleValuesToCustomList_AddedValueGoesToNextIncrement()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int itemToAdd2 = 12;
            int expected = 2;
            int actual;
            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd2);
            actual = testList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingMultipleValuesToEmptyCustomList_CapacityOfCustomList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 8;
            int actual;
            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);

            actual = testList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
        // what happens if you add multiple things (or add to a CustomList that already has some values)?
            // what happens to the last-added item?
            // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
//capacity is built into list
//T[] items = new T[4]; default
//behind the scenes in add method there's something that doubles the amount of items in list. reserve memory capacity.
//increased size of array
//int[] items = new int[4];
//items = new int[8]; ---- this removes first array so bye bye 
//need logic to copy values