using System;
using DecodeMorse;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecodeMorseTest
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Test Morse Code
        /// </summary>
        [TestMethod]
        public void TestMorseCode()
        {
            Assert.AreEqual("HEY JUDE", Program.Translate(" .... . -.--   .--- ..- -.. . "));
        }
    }
}
