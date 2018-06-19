using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMD5;

namespace UnitTestsMD5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Encoding_Text_BinaryString()
        {
            var md5 = CreateMd5();

            var binaryString = md5.StepOne("hi");

            Assert.AreEqual("0110100001101001" +
                "1" +
                "000000000000000000000" +
                "0000000000000000000000000000000000000000000000000" +
                "0000000000000000000000000000000000000000000000000000" +
                "00000000000000000000000000000000000000000000000000000" +
                "0000000000000000000000000000000000000000000000000000000" +
                "0000000000000000000000000000000000000000000000000000000000000" +
                "00000000000000000000000000000000000000000000000000000000000000000" +
                "0000000000000000000000000000000000000000000000000000000000000" +
                "00000000000000", binaryString);
        }

   

        public FindMD5 CreateMd5()
        {

            return new FindMD5();

        }


    }
}
