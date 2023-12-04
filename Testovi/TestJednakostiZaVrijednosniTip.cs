using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    using Osoba = EqualsZaVrijednosniTip.Osoba;

    [TestClass]
    public class TestJednakostiZaVrijednosniTip : ConsoleTest
    {
        [TestMethod]
        public void VraćaTrueZaIsteOsobe()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            JednakostZaVrijedniTip.Jednakost(osobaA, osobaB);
            Assert.IsTrue(cw?.GetString().ToLower().EndsWith("true"));
            Assert.IsTrue(cw?.GetString().ToLower().EndsWith("false"));
        }

        [TestMethod]
        public void VraćaTrueZaJednakeOsobe()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 1);
            JednakostZaVrijedniTip.Jednakost(osobaA, osobaB);
            Assert.IsTrue(cw?.GetString().ToLower().EndsWith("true"));
            Assert.IsTrue(cw?.GetString().ToLower().EndsWith("false"));
        }

        [TestMethod]
        public void VraćaFalseZaRazličiteOsobe()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 2);
            JednakostZaVrijedniTip.Jednakost(osobaA, osobaB);
            Assert.IsTrue(cw?.GetString().ToLower().EndsWith("false"));
            Assert.IsTrue(cw?.GetString().ToLower().EndsWith("true"));
        }
    }
}
