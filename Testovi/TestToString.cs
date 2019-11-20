using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    [TestClass]
    public class TestToString
    {
        [TestMethod]
        public void VraćaTekstZaKompleksniBrojSRealnimIPozitvnimImaginarnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(2, 3);
            Assert.AreEqual("2+3j", kb.ToString());
        }

        [TestMethod]
        public void VraćaTekstZaKompleksniBrojSRealnimINegativnimImaginarnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(2, -3);
            Assert.AreEqual("2-3j", kb.ToString());
        }

        [TestMethod]
        public void VraćaTekstZaKompleksniBrojSamoSNegativnimImaginarnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(0, -3);
            Assert.AreEqual("-3j", kb.ToString());
        }

        [TestMethod]
        public void VraćaTekstZaImaginarnuJedinicu()
        {
            KompleksniBroj kb = new KompleksniBroj(0, 1);
            Assert.AreEqual("j", kb.ToString());
        }

        [TestMethod]
        public void VraćaTekstZaNulu()
        {
            KompleksniBroj kb = new KompleksniBroj(0, 0);
            Assert.AreEqual("0", kb.ToString());
        }

        [TestMethod]
        public void VraćaTekstZaBrojSamoSNegativnimRealnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(-2, 0);
            Assert.AreEqual("-2", kb.ToString());
        }
    }
}
