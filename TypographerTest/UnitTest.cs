using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using Typograph;

namespace TypographTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FirstRuleTest()
        {
            string testResult = Rules.FirstRule("\" Я , человек , который… живет на юпитере \"");
            string rightResult = "\"Я,  человек,  который…  живет на юпитере\"";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void SecondRuleTest()
        {
            string testResult = Rules.SecondRule("ля  ляля  ляля  ");
            string rightResult = "ля ляля ляля ";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void SixthRuleTest()
        {
            string testResult = Rules.SixthRule("Книга - супер классная вещь");
            string rightResult = "Книга — супер классная вещь";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void ThirteenthRuleTest()
        {
            string testResult = Rules.ThirteenthRule("Боль... Домашка... А еще ведь отчет писать...");
            string rightResult = "Боль… Домашка… А еще ведь отчет писать…";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void FirstOwnRuleTest()
        {
            string testResult = Rules.FirstOwnRule("Я люблю делать историю");
            string rightResult = "Я люблю делать историю.";
            Assert.AreEqual(rightResult, testResult);
        }
        [TestMethod]
        public void SecondOwnRuleTest()
        {
            string testResult = Rules.SecondOwnRule("черт блин опять эта история в среду");
            string rightResult = "*плохое слово* *плохое слово* опять эта история в среду";
            Assert.AreEqual(rightResult, testResult);
        }



        [TestMethod]
        public void DontKnowTest1()
        {

        }
        [TestMethod]
        public void DontKnowTest2()
        {

        }
        [TestMethod]
        public void DontKnowTest3()
        {

        }
        [TestMethod]
        public void DontKnowTest4()
        {

        }
        [TestMethod]
        public void DontKnowTest5()
        {

        }
        [TestMethod]
        public void DontKnowTest6()
        {

        }
        [TestMethod]
        public void DontKnowTest7()
        {

        }
        [TestMethod]
        public void DontKnowTest8()
        {

        }
        [TestMethod]
        public void DontKnowTest9()
        {

        }
    }
}
