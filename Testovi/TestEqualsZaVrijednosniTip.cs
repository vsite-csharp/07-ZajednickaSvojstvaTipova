using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Linq;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    using Osoba = EqualsZaVrijednosniTip.Osoba;

    [TestClass]
    public class TestMetodeEqualsZaVrijednosniTip
    {
        [TestMethod]
        public void ZaObjekteSRazličitimČlanovimaVraćaFalse()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void ZaOsobeSJednakimImenomRazličitimMatičnimBrojemVraćaFalse()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 2);

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void ZaOsobeSRazličitimImenimaIstimMatičnimBrojemVraćaTrue()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 1);

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsTrue(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void ZaKopijuOsobeVraćaTrue()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsTrue(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void ZaOsobeSJednakimImenimaIMatičnimBrojevimaVraćaTrue()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 1);

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsTrue(osobaA.Equals(osobaB));
        }
    }
}
