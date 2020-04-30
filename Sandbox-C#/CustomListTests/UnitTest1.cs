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

        //2, 4, 6, 8
        //2, 4, 6, 8, 10
        [TestMethod]
        public void Add_AddNewValueToListAndCopyOldList_CopiedCorrectly()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();

            //act
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(25);
            testList.Add(30);

            //assert
            Assert.AreEqual(10, testList[0]);
        }


        //1. { 1, 2, 3 } => { 1, 3 }
        [TestMethod]
        public void Remove_RemovedItemInList_ValuesShiftOver()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();

            //act
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Remove(15);

            //assert
            Assert.AreEqual(20, testList[1]);
        }

        [TestMethod]
        public void Remove_RemovedItemInListAddAfterRemoval_ValuesShiftOver()
        {
            CustomList<int> testList = new CustomList<int>();

            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Remove(15);
            testList.Add(25);

            Assert.AreEqual(25, testList[2]);
        }

        [TestMethod]
        public void Remove_RemoveFirstValueInList_CountValuesCustomList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToRemove = 10;
            int expected = 0;
            int actual;

            // act
            testList.Add(itemToRemove);
            testList.Remove(itemToRemove);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveRepeatedValueInList_ValuesShiftOver()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 20;

            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(15);
            testList.Remove(15);
            int actual = testList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveTwoValuesInList_ValuesCopyCorrectly()
        {
            CustomList<int> testList = new CustomList<int>();
            
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(15);
            testList.Remove(15);
            testList.Remove(20);

            Assert.AreEqual(15, testList[1]);
        }
        [TestMethod]
        public void Remove_RemoveTwoValuesInList_CountValuesCustomList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(15);
            testList.Remove(15);
            testList.Remove(20);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveTwoSameValuesInList_CountValuesInCustomList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(15);
            testList.Remove(15);
            testList.Remove(15);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveTwoSameValuesInList_FirstValueShiftsCorrectlyInCustomList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 10;

            // act
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(15);
            testList.Remove(15);
            testList.Remove(15);

            int actual = testList[0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveTwoSameValuesInList_SecondValueShiftsCorrectlyInCustomList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 20;
            int actual;

            // act
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(15);
            testList.Remove(15);
            testList.Remove(15);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_RemoveValueAtEndOfList_ExceptionThrown()
        {
            CustomList<int> testList = new CustomList<int>();

            testList.Add(10);
            testList.Add(15);
            testList.Add(20);

            int value = testList[3];
        }

        //"26810"
        //string result = numbers.ToString();
        [TestMethod]
        public void ToString_ConvertItemToString_ItemIsString()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "23";
            string actual;
            
            //act
            testList.Add(2);
            testList.Add(3);
            testList.ToString();
            actual = testList.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
//capacity is built into list
//T[] items = new T[4]; default
//behind the scenes in add method there's something that doubles the amount of items in list. reserve memory capacity.
//increased size of array
//int[] items = new int[4];
//items = new int[8]; ---- this removes first array so bye bye 
//need logic to copy values
// what happens if you add multiple things (or add to a CustomList that already has some values)?
// what happens to the last-added item?
// what happens to the Count?

// what happens if you add more items than the initial Capacity of the CustomList?
//remove a value that is not even in the list