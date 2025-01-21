using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PlesovskikhBA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PlesovskikhBA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Борис";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Борис", res);
        }
    }
}
