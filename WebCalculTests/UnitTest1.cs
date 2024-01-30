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
		public void ApplyOperand_DecimalAddition_ReturnsCorrectSum()
		{
			var calc = new Calcul(5.5m, 3.3m, '+');
			var result = calc.ApplyOperand();
			Assert.AreEqual(8.8m, result);
		}

		[TestMethod]
		public void ApplyOperand_DecimalSubtraction_ReturnsCorrectDifference()
		{
			var calc = new Calcul(5.5m, 3.3m, '-');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2.2m, result); 
		}

		[TestMethod]
		public void ApplyOperand_DecimalMultiplication_ReturnsCorrectProduct()
		{
			var calc = new Calcul(5.5m, 2m, '*');
			var result = calc.ApplyOperand();
			Assert.AreEqual(11m, result);
		}

		[TestMethod]
		public void ApplyOperand_DecimalDivision_ReturnsCorrectQuotient()
		{
			var calc = new Calcul(5.5m, 2m, '/');
			var result = calc.ApplyOperand();
			Assert.AreEqual(2.75m, result); 
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void ApplyOperand_DecimalDivisionByZero_ThrowsException()
		{
			var calc = new Calcul(5.5m, 0m, '/');
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

		[TestMethod]
		public void AppendIntoMinMem_AppendsValue_ReturnsTrue()
		{
			var calc = new Calcul();
			var result = calc.AppendIntoMinMem(5.5m);
			Assert.IsTrue(result);
			Assert.AreEqual(5.5m, calc.MinMemStoreLast());
		}

		[TestMethod]
		public void AppendIntoPlusMem_AppendsValue_ReturnsTrue()
		{
			var calc = new Calcul();
			var result = calc.AppendIntoPlusMem(3.3m);
			Assert.IsTrue(result);
			Assert.AreEqual(3.3m, calc.PlusMemStoreLast());
		}

		[TestMethod]
		public void ResultFromMemory_CalculatesCorrectResult()
		{
			var calc = new Calcul();
			calc.AppendIntoPlusMem(10.0m);
			calc.AppendIntoPlusMem(20.0m);
			calc.AppendIntoMinMem(5.0m);
			calc.AppendIntoMinMem(3.0m);
			var result = calc.ResultFromMemory();
			Assert.AreEqual(22.0m, result);
		}
		[TestMethod]
		public void ResultFromMemory_CalculatesCorrectResultFractions()
		{
			var calc = new Calcul();
			calc.AppendIntoPlusMem(55.33m);
			calc.AppendIntoMinMem(55.0m);
			var result = calc.ResultFromMemory();
			Assert.AreEqual(0.33m, result);
		}
	}
}
