using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    [TestClass]
    public class TestClone : ConsoleTest
    {
        [TestMethod]
        public void Clone_VraćaNoviObjektSIstimSadržajem()
        {
            Clone.Jednakost();
            Assert.IsTrue(cw.GetString().EndsWith("False"));
            Assert.IsTrue(cw.GetString().EndsWith("True"));
            Assert.IsTrue(cw.GetString().EndsWith("False"));
        }
    }
}
