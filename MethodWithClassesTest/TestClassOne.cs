using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodsWithClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodWithClassesTest
{
    [TestClass]
    public class TestClassOne
    {
        [TestMethod]
        public void TestMethodOne()
        {
            Calculator calculator = new Calculator();
            int result = calculator.AdditionMethod(1, 10);
            Assert.AreEqual(1 + 10, result);

        }
    }
}
