
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace WebCalcul.Data
{
    public class Calcul
    {
        private float a;
        private float b;
        private char activeOperator;

		public Calcul(){}
		public Calcul(float numA, float numB, char oper)
        {
            a = numA;
            b = numB;
            activeOperator = oper;
        }

		public float ApplyOperand()
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
				default: return 0;
			}
		}

		// Properties
		public float A
		{
			get { return a; }
			set { a = value; }
		}

		public float B
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
