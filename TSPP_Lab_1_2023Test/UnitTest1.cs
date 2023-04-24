namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 4;
            double V = ConsoleApp1_24.Program.dobutok(a);
            double S = ConsoleApp1_24.Program.plocha(a);
            Assert.AreEqual(64, V);
            Assert.AreEqual(96, S);
        }
    }
}
