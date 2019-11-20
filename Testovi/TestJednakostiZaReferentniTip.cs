using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Linq;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    [TestClass]
    public class TestJednakostiZaReferentniTip
    {
        [TestMethod]
        public void VraćaFalseZaUsporedbuOsobeSNullReferencom()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = null;

            Assert.IsNotNull(typeof(Osoba).GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(mi => mi.Name == "op_Equality"));

            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }

        [TestMethod]
        public void VraćaFalseZaUsporedbuNullReferenceSOsobom()
        {
            Osoba osobaA = null;
            Osoba osobaB = new Osoba("Janko", 1);

            Assert.IsNotNull(typeof(Osoba).GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(mi => mi.Name == "op_Equality"));

            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }

        [TestMethod]
        public void VraćaTrueZaDvijeOsobeJednakihImenaIMatičnogBroja()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 1);

            Assert.IsNotNull(typeof(Osoba).GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(mi => mi.Name == "op_Equality"));

            Assert.IsTrue(osobaA == osobaB);
            Assert.IsFalse(osobaA != osobaB);
        }

        [TestMethod]
        public void VraćaFalseZaDvijeOsobeJednakihImenaRazličitihMatičnihBrojeva()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 2);

            Assert.IsNotNull(typeof(Osoba).GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(mi => mi.Name == "op_Equality"));

            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }

        [TestMethod]
        public void VraćaFalseZaDvijeOsobeRazličitihImenaJednakihMatičnihBrojeva()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 1);

            Assert.IsNotNull(typeof(Osoba).GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(mi => mi.Name == "op_Equality"));

            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }
    }
}
