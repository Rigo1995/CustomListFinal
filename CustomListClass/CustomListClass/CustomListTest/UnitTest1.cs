using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddFour_Expect_zero()
        {
            //Arrange
            CustomList<int> MyList = new CustomList<int>();

            //Act
            MyList.Add(4);

            //Assert
            Assert.AreEqual(4, MyList[0]);
        }

        [TestMethod]
        public void Add_Numbers_Expect_three()
        {
            CustomList<int> MyList = new CustomList<int>();
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            int expectedValue = 4;
            int actualValue = MyList[3];

            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void Adddecimalds_expect_Twelve()
        {
            CustomList<double> MyList = new CustomList<double>();
            MyList.Add(.50);

            Assert.AreEqual(MyList[0], .50);

        }

        [TestMethod]
        
        public void AddAllNumbers()
        {
            CustomList<double> MyList = new CustomList<double>();
            int expected = 8;

            MyList.Add(4);
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(.50);
            MyList.Add(.50);
            MyList.Add(.50);

           int actual = MyList.Count;
            
           Assert.AreEqual(expected, actual);
        }



    }
}
