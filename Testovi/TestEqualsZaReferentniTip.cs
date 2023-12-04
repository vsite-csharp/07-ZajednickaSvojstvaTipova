using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Linq;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    [TestClass]
    public class TestEqualsZaReferentniTip
    {
        [TestMethod]
        public void UsporedbaReferenciNaIstiObjektUvijekVraćaTrue()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = o1;

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsTrue(o1.Equals(o2));
            Assert.IsTrue(o2.Equals(o1));
            Assert.IsTrue(Osoba.Equals(o1, o2));
            Assert.IsTrue(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void UsporedbaDvijuOsobaSRazličitimImenimaRazličitimMatičnimBrojemVraćaFalse()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = new Osoba("Marko", 2);

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsFalse(o1.Equals(o2));
            Assert.IsFalse(o2.Equals(o1));
            Assert.IsFalse(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void UsporedbaDvijuOsobaSIstimImenimaRazličtitimMatičnimBrojemVraćaFalse()
        {
            Osoba? o1 = new Osoba("Janko", 1);
            Osoba? o2 = new Osoba("Janko", 2);

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsFalse(o1.Equals(o2));
            Assert.IsFalse(o2.Equals(o1));
            Assert.IsFalse(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void UsporedbaSNullReferencomVraćaFalse()
        {
            Osoba? o1 = new Osoba("Janko", 1);
            Osoba? o2 = null;

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsFalse(o1.Equals(o2));
            Assert.IsFalse(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void UsporedbaDvijuOsobaSIstimImenimaIstimMatičnimBrojemVraćaTrue()
        {
            Osoba? o1 = new Osoba("Janko", 1);
            Osoba? o2 = new Osoba("Janko", 1);

            Assert.IsTrue(typeof(Osoba).GetInterfaces().Contains(typeof(IEquatable<Osoba>)));

            Assert.IsTrue(o1.Equals(o2));
            Assert.IsTrue(o2.Equals(o1));
            Assert.IsTrue(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }
    }
}
