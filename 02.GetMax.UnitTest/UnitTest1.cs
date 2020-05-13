namespace _02.GetMax.UnitTest
{

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = GetMax.GetMaxNumber(5, 4);

            Assert.AreEqual(5, test);
        }
    }

}