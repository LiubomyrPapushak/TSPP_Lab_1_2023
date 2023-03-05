using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TSPP_Lab_1_2023Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Тестовий набір данних
            uint S = 3680;
            uint hh = 1;
            uint mm = 1;
            uint ss = 20;
            //Змінні на тестування
            uint thh = TSPP_Lab_1_2023.Program.TimeConvH(S);
            uint tmm = TSPP_Lab_1_2023.Program.TimeConvM(S);
            uint tss = TSPP_Lab_1_2023.Program.TimeConvS(S);
            //Перевірка
            Assert.AreEqual(hh, thh);
            Assert.AreEqual(mm, tmm);
            Assert.AreEqual(ss, tss);
        }
    }
}
