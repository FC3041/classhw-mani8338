namespace ComplexNumberTest
{
    [TestClass]
    public class ComplexNumberTests
    {
        [TestMethod]
        public void AddTest()
        {
            var c1 = new ComplexNumber<int>(3,4);
            var c2 = new ComplexNumber<int>(1,2);
            var cSum = c1.Add(c2);
            var cExpectedSum = new ComplexNumber<int>(4, 6);
            Assert.AreEqual(cSum, cExpectedSum);
        }
        [TestMethod]
        public void MagnitudeTest()
        {
            var c = new ComplexNumber<int>(3,4);
            Assert.AreEqual(c.Magnitude,5); 
        }
    }
}