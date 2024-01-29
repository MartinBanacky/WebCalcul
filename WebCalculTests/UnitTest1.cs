using WebCalcul.Data;

namespace WebCalculTests
{
	[TestClass]
	public class CalculTests
	{
		[TestMethod]
		public void ApplyOperand_Addition_ReturnsCorrectSum()
		{
			var calc = new Calcul(5, 4, '+');
			var result = calc.ApplyOperand();
			Assert.AreEqual(9, result);
		}

		[TestMethod]
		public void ApplyOperand_Subtraction_ReturnsCorrectDifference()
		{
			var calc = new Calcul(5,3,'-');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void ApplyOperand_Multiplication_ReturnsCorrectProduct()
		{
			var calc = new Calcul(5, 3, '*');
			var result = calc.ApplyOperand();
			Assert.AreEqual(15, result);
		}

		[TestMethod]
		public void ApplyOperand_Division_ReturnsCorrectQuotient()
		{
			var calc = new Calcul(6, 3, '/');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2, result);
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void ApplyOperand_DivisionByZero_ThrowsException()
		{
			var calc = new Calcul(5, 0, '/');
			calc.ApplyOperand();
		}

		[TestMethod]
		public void ApplyOperand_DoubleAddition_ReturnsCorrectSum()
		{
			var calc = new Calcul(5.5d, 3.3d, '+');
			var result = calc.ApplyOperand();
			Assert.AreEqual(8.8d, result, 0.0001d);
		}

		[TestMethod]
		public void ApplyOperand_DoubleSubtraction_ReturnsCorrectDifference()
		{
			var calc = new Calcul(5.5d, 3.3d, '-');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2.2d, result, 0.0001d); 
		}

		[TestMethod]
		public void ApplyOperand_DoubleMultiplication_ReturnsCorrectProduct()
		{
			var calc = new Calcul(5.5d, 2d, '*');
			var result = calc.ApplyOperand();
			Assert.AreEqual(11d, result, 0.0001d);
		}

		[TestMethod]
		public void ApplyOperand_DoubleDivision_ReturnsCorrectQuotient()
		{
			var calc = new Calcul(5.5d, 2d, '/');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2.75d, result, 0.0001d); 
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void ApplyOperand_DoubleDivisionByZero_ThrowsException()
		{
			var calc = new Calcul(5.5d, 0d, '/');
			calc.ApplyOperand();
		}

		//unit tests with ApplyPercentageOperand

		[TestMethod]
		public void ApplyPercentageOperand_Addition_ReturnsCorrectSum()
		{
			var calc = new Calcul(600,20, '+');
			var result = calc.ApplyPercentageOperand();
			Assert.AreEqual(720, result);
		}

		[TestMethod]
		public void ApplyPercentageOperand_Substraction_ReturnsCorrectSum()
		{
			var calc = new Calcul(600, 20, '-');
			var result = calc.ApplyPercentageOperand();
			Assert.AreEqual(480, result);
		}

		[TestMethod]
		public void ApplyPercentageOperand_Multiplication_ReturnsCorrectSum()
		{
			var calc = new Calcul(600, 20, '*');
			var result = calc.ApplyPercentageOperand();
			Assert.AreEqual(120, result);
		}

		[TestMethod]
		public void ApplyPercentageOperand_Division_ReturnsCorrectSum()
		{
			var calc = new Calcul(600, 20, '/');
			var result = calc.ApplyPercentageOperand();
			Assert.AreEqual(3000, result);
		}
	}
}
