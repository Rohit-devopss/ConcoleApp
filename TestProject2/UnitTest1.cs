using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;


namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}