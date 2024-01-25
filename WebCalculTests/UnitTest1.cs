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
		public void ApplyOperand_FloatAddition_ReturnsCorrectSum()
		{
			var calc = new Calcul(5.5f, 3.3f, '+');
			var result = calc.ApplyOperand();
			Assert.AreEqual(8.8f, result, 0.0001f); // Using a delta for float comparison
		}

		[TestMethod]
		public void ApplyOperand_FloatSubtraction_ReturnsCorrectDifference()
		{
			var calc = new Calcul(5.5f, 3.3f, '-');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2.2f, result, 0.0001f); // Using a delta for float comparison
		}

		[TestMethod]
		public void ApplyOperand_FloatMultiplication_ReturnsCorrectProduct()
		{
			var calc = new Calcul(5.5f, 2f, '*');
			var result = calc.ApplyOperand();
			Assert.AreEqual(11f, result, 0.0001f); // Using a delta for float comparison
		}

		[TestMethod]
		public void ApplyOperand_FloatDivision_ReturnsCorrectQuotient()
		{
			var calc = new Calcul(5.5f, 2f, '/');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2.75f, result, 0.0001f); // Using a delta for float comparison
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void ApplyOperand_FloatDivisionByZero_ThrowsException()
		{
			var calc = new Calcul(5.5f, 0f, '/');
			calc.ApplyOperand();
		}
	}
}
