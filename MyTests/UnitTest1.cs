using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;
using System;

namespace MyTests
{
    [TestClass]
    public class UnitTest1
    {
        Change _test = new Change();

        [TestMethod]
        public void ReadStatusTest() //проверка параметра
        {
            string ReadInf = _test.ReadStatus("User");
            string status = "User";
            Assert.AreEqual(ReadInf, status);
        }

        [TestMethod]
        public void UpdateStatusTest() //проверка изменения параметра
        {
            string updateInfo = _test.UpdateStatus(5, "User3", "User3", "User");
            string status = "User";
            Assert.AreEqual(updateInfo, status);
        }
    }
}
