using RecuParcialPOO.TomasBlencio.Entidades;

namespace RecuParcialPOO.TomasBlencio.TestingPunto01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingGetAreaBase()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(5, 10, 5);
            Assert.AreNotEqual(2, prisma.GetAreaBase());
        }
        [TestMethod]
        public void TestingGetAreaAltura()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(5, 10, 5);
            Assert.AreNotEqual(2, prisma.GetAreaAltura());
        }
        [TestMethod]
        public void TestingGetAreaAncho()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(5, 10, 5);
            Assert.AreEqual(25, prisma.GetAreaAncho());
        }
        [TestMethod]
        public void TestingGetArea()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(5, 10, 5);
            Assert.AreEqual(250,prisma.GetArea());
        }
        [TestMethod]
        public void TestingGetVolumen()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto(5, 10, 5);
            Assert.AreEqual(250, prisma.GetVolumen());
        }
    }
}