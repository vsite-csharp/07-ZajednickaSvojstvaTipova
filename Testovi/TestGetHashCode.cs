using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Collections.Generic;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    [TestClass]
    public class TestGetHashCode
    {
        [TestMethod]
        public void GetHashCodeOmogućavaKorištenjeKlaseKaoKljučaURiječniku()
        {
            Dictionary<Osoba, string> mjestaRođenja = new Dictionary<Osoba, string>();
            mjestaRođenja[new Osoba("Pero", 1)] = "Babina Greda";
            mjestaRođenja[new Osoba("Janko", 2)] = "Jarče Polje";
            mjestaRođenja[new Osoba("Darko", 3)] = "Vukova Gorica";

            Assert.AreEqual("Babina Greda", mjestaRođenja[new Osoba("Pero", 1)]);
            Assert.AreEqual("Vukova Gorica", mjestaRođenja[new Osoba("Darko", 3)]);
            Assert.AreEqual("Jarče Polje", mjestaRođenja[new Osoba("Janko", 2)]);
        }
    }
}
