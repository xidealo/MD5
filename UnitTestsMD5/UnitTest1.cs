using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMD5;

namespace UnitTestsMD5
{
    [TestClass]
    public class UnitTest1
    {
     
        [TestMethod]
        public void CheckSum_Md5()
        {
            var md5 = new MyMD5.MyMD5();

            var hash = md5.CheckSum("hi");

            Assert.AreEqual("98313755022045530244343041484663159867", hash);
        }

      


    }
}
