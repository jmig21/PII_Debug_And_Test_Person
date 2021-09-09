using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    
    [TestFixture]
    public class Tests
    {
        

        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            Person p = new Person("Gonzalo", "2.686.797-9", "01/01/1901");
            string expected = "Gonzalo";
            Assert.AreEqual(expected, p.Name);
        }

        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Gonzalo", "2.686.797-9", "01/01/01");
            string expected = "2.686.797-9";
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestFechNac() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Gonzalo", "2.686.797-9", "01/01/01");
            string expected = "01/02/2003"; //En algún lado por acá se puede probar con Int32.TryParse
            Assert.AreEqual(expected, p.FechaNac);
        }

    }
}