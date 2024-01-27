
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace WebCalcul.Data
{
    public class Calcul
    {
        private double a;
        private double b;
        private char activeOperator;

		public Calcul(){}
		public Calcul(double numA, double numB, char oper)
        {
            a = numA;
            b = numB;
            activeOperator = oper;
        }

		public double ApplyOperand()
		{
			switch (activeOperator)
			{
				case '+': return a = a + b;
				case '-': return a = a - b;
				case '*': return a = a * b;
				case '/':
					if (b != 0 && a != 0)
					{
						return a = a / b;
					}
					else throw new DivideByZeroException("Division by zero is not allowed.");
				default: return b;
			}
		}

		public bool CheckOperator()
		{
			return activeOperator > 0;
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
