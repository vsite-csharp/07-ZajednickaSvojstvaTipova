using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    [TestClass]
    public class TestEquals : ConsoleTest
    {
        [TestMethod]
        public void UsporedbaKlasa()
        {
            try
            {
                MetodaEquals.UsporedbaKlasa();
            }
            catch (NullReferenceException)
            {
            }

            Assert.AreEqual(false, cw?.GetBoolean());
            Assert.AreEqual(false, cw?.GetBoolean());
            Assert.AreEqual(false, cw?.GetBoolean());
            Assert.IsTrue(cw?.IsEmpty);
        }
    }
}
