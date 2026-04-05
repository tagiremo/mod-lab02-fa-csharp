using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fans;

namespace NET
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test_FA1_Valid_1()
        {
            string s = "0111";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA1_Valid_2()
        {
            string s = "1110111";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA1_Valid_3()
        {
            string s = "10";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA1_Valid_4()
        {
            string s = "1101";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA1_Valid_5()
        {
            string s = "101111111";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA1_Invalid_NoZero()
        {
            string s = "111";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA1_Invalid_TwoZeros()
        {
            string s = "01011";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA1_Invalid_ThreeZeros()
        {
            string s = "110101011";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA1_Invalid_OnlyZero()
        {
            string s = "0";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA1_Invalid_NoOnes()
        {
            string s = "0";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA1_Invalid_Empty()
        {
            string s = "";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA1_InvalidCharacter()
        {
            string s = "01a2";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == null);
        }

        
        [TestMethod]
        public void Test_FA2_Valid_1()
        {
            string s = "01";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA2_Valid_2()
        {
            string s = "0001";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA2_Valid_3()
        {
            string s = "111000";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA2_Valid_4()
        {
            string s = "000111";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA2_Valid_5()
        {
            string s = "001011";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA2_Invalid_EvenEven()
        {
            string s = "0101";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA2_Invalid_EvenOdd()
        {
            string s = "00110011";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA2_Invalid_OddEven()
        {
            string s = "001";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA2_Invalid_Empty()
        {
            string s = "";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA2_InvalidCharacter()
        {
            string s = "01b3";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == null);
        }

        
        [TestMethod]
        public void Test_FA3_Valid_1()
        {
            string s = "00110011";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA3_Valid_2()
        {
            string s = "10110";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA3_Valid_3()
        {
            string s = "11";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA3_Valid_4()
        {
            string s = "011";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA3_Valid_5()
        {
            string s = "110";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void Test_FA3_Invalid_NoConsecutiveOnes()
        {
            string s = "0101";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA3_Invalid_OnlyOne()
        {
            string s = "1";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA3_Invalid_10101()
        {
            string s = "10101";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA3_Invalid_Empty()
        {
            string s = "";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA3_Invalid_OnlyZeros()
        {
            string s = "00000";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void Test_FA3_InvalidCharacter()
        {
            string s = "11c4";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == null);
        }
    }
}
