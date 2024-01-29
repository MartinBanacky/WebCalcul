
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace WebCalcul.Data
{
    public class Calcul
    {
        private double a;
        private double b;
        private char activeOperator;
		private List<double> MinMemStore;
		private List<double> PlusMemStore;

		public Calcul(){
			MinMemStore = new List<double>();
			PlusMemStore = new List<double>();
		}
		public Calcul(double numA, double numB, char oper)
        {
            a = numA;
            b = numB;
            activeOperator = oper;
			MinMemStore = new List<double>();
			PlusMemStore = new List<double>();
		}

		public double ApplyOperand()
		{
			switch (activeOperator)
			{
				case '+': return a += b;
				case '-': return a -= b;
				case '*': return a *= b;
				case '/':
					if (b != 0 && a != 0)
					{
						return a /= b;
					}
					else throw new DivideByZeroException("Division by zero is not allowed.");
				default: return a += b;
			}
		}

		public double ApplyPercentageOperand()
		{
			switch (activeOperator)
			{
				case '+':
					A = a * (b + 100) / 100;
					B = 0;
					activeOperator = '\0';
					return A;
				case '-':
					A = a * (100 - b) / 100;
					B = 0;
					activeOperator = '\0';
					return A;
				case '*':
					A = a * b / 100;
					B = 0;
					activeOperator = '\0';
					return A;
				case '/':
					A = a / (b / 100);
					return A;
				default:
					return A;
			}
		}

		public bool AppendIntoMinMem(double num)
		{
			MinMemStore.Add(num);
			return true;
		}

		public bool AppendIntoPlusMem(double num)
		{
			PlusMemStore.Add(num); 
			return true;
		}

		public double ResultFromMemory()
		{
			double sumPlus = PlusMemStore.Sum();
			double sumMinus = MinMemStore.Sum();
			B = 0;
			ActiveOperator = '\0';
			return A = sumPlus - sumMinus;
		}

		public void ApplyPercentage()
		{
			A = Math.Sqrt(A);
		}

		public bool CheckOperatorActive()
		{
			return activeOperator > 1;
		}

		// Properties
		public double A
		{
			get { return a; }
			set { a = value; }
		}

		public double B
		{
			get { return b; }
			set { b = value; }
		}

		public char ActiveOperator
		{
			get { return activeOperator; }
			set { activeOperator = value; }
		}
    }
}
