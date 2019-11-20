using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.ZajedničkaSvojstvaTipova.Testovi
{
    [TestClass]
    public class TestEqualsZaIzvedeniReferentiTip
    {
        [TestMethod]
        public void UsporedbaReferenciNaIstiObjektUvijekVraćaTrue()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = s1;

            Assert.IsTrue(typeof(Student).GetInterfaces().Contains(typeof(IEquatable<Student>)));

            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(s2.Equals(s1));
            Assert.IsTrue(Osoba.Equals(s1, s2));
            Assert.IsTrue(Osoba.ReferenceEquals(s1, s2));
        }

        [TestMethod]
        public void UsporedbaDvijeIsteOsobeSRazličitimSmjeromIGodinomVraćaFalse()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Janko", 1, "elektronika", 3);

            Assert.IsTrue(typeof(Student).GetInterfaces().Contains(typeof(IEquatable<Student>)));

            Assert.IsFalse(s1.Equals(s2));
            Assert.IsFalse(s2.Equals(s1));
            Assert.IsFalse(Osoba.Equals(s1, s2));
            Assert.IsFalse(Osoba.ReferenceEquals(s1, s2));
        }

        [TestMethod]
        public void UsporedbaDvijeIsteOsobeSIstogSmjeraIGodineVraćaTrue()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Janko", 1, "računarstvo", 3);

            Assert.IsTrue(typeof(Student).GetInterfaces().Contains(typeof(IEquatable<Student>)));

            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(s2.Equals(s1));
            Assert.IsTrue(Osoba.Equals(s1, s2));
            Assert.IsFalse(Osoba.ReferenceEquals(s1, s2));
        }

        [TestMethod]
        public void UsporedbaDvijeRazličiteOsobeSIstogSmjeraIGodineVraćaFalse()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Marko", 3, "računarstvo", 3);

            Assert.IsTrue(typeof(Student).GetInterfaces().Contains(typeof(IEquatable<Student>)));

            Assert.IsFalse(s1.Equals(s2));
            Assert.IsFalse(s2.Equals(s1));
            Assert.IsFalse(Osoba.Equals(s1, s2));
            Assert.IsFalse(Osoba.ReferenceEquals(s1, s2));
        }
    }
}
