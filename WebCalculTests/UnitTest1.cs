//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using WebCalcul.Data;

//namespace WebCalculTests
//{
//    [TestClass]
//    public class CalculTests
//    {
//        [TestMethod]
//        public void ApplyOperand_Addition_ReturnsCorrectSum()
//        {
//            var result = Cal.ApplyOperand(5, 3, '+');
//            Assert.AreEqual(8, result);
//        }

//        [TestMethod]
//        public void ApplyOperand_Subtraction_ReturnsCorrectDifference()
//        {
//            var result = Cal.ApplyOperand(5, 3, '-');
//            Assert.AreEqual(2, result);
//        }

//        [TestMethod]
//        public void ApplyOperand_Multiplication_ReturnsCorrectProduct()
//        {
//            var result = Cal.ApplyOperand(5, 3, '*');
//            Assert.AreEqual(15, result);
//        }

//        [TestMethod]
//        public void ApplyOperand_Division_ReturnsCorrectQuotient()
//        {
//            var result = Cal.ApplyOperand(6, 3, '/');
//            Assert.AreEqual(2, result);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(DivideByZeroException))]
//        public void ApplyOperand_DivisionByZero_ThrowsException()
//        {
//            Cal.ApplyOperand(5, 0, '/');
//        }
//    }
//}
