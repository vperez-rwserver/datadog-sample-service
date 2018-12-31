using System;
using ManualInstrumentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManualInstrumentationTests
{
    [TestClass]
    public class TraceSampleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var traceSample = new TraceSample();

            var result = traceSample.Method1();
            Assert.IsTrue(result.Contains("1"));
        }
    }
}
