﻿using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace WebCalcul.Data
{
    public class Calcul
    {
        private decimal a;
        private decimal b;
        private char activeOperator;
		private List<decimal> MinMemStore;
		private List<decimal> PlusMemStore;

		public Calcul(){
			MinMemStore = new List<decimal>();
			PlusMemStore = new List<decimal>();
		}
		public Calcul(decimal numA, decimal numB, char oper)
        {
            a = numA;
            b = numB;
            activeOperator = oper;
			MinMemStore = new List<decimal>();
			PlusMemStore = new List<decimal>();
		}

		public decimal ApplyOperand()
		{
			switch (activeOperator)
			{
				case '+': return a += b;
				case '*': return a *= b;
				case '-': return a -= b;
				case '/':
					if (b != 0 && a != 0)
					{
						return a /= b;
					}
					else throw new DivideByZeroException("Division by zero is not allowed.");
				default: return a += b;
			}
		}

		public decimal ApplyPercentageOperand()
		{
			switch (activeOperator)
			{
				case '+':
					A = a * (b + 100) / 100;
					//B = 0;
					//activeOperator = '\0';
					return A;
				case '-':
					A = a * (100 - b) / 100;
					//B = 0;
					//activeOperator = '\0';
					return A;
				case '*':
					A = a * b / 100;
					//B = 0;
					//activeOperator = '\0';
					return A;
				case '/':
					A = a / (b / 100);
					return A;
				default:
					return A;
			}
		}

		public bool AppendIntoMinMem(decimal num)
		{
			MinMemStore.Add(num);
			return true;
		}

		public bool AppendIntoPlusMem(decimal num)
		{
			PlusMemStore.Add(num); 
			return true;
		}

		public decimal ResultFromMemory()
		{
			decimal sumPlus = PlusMemStore.Sum();
			decimal sumMinus = MinMemStore.Sum();
			B = 0;
			ActiveOperator = '\0';
			return A = sumPlus - sumMinus;
		}

		public static decimal Sqrt(decimal x, decimal epsilon = 0.0M)
		{
			if (x < 0)
			{
				throw new OverflowException("Cannot calculate square root from a negative number");
			}

			decimal current = (decimal)Math.Sqrt((double)x), previous;
			do
			{
				previous = current;
				if (previous == 0.0M) return 0;
				current = (previous + x / previous) / 2;
			}
			while (Math.Abs(previous - current) > epsilon);
			return current;
		}

		public void ApplyPercentage()
		{
			A = Sqrt(A);
		}

		public bool CheckOperatorActive()
		{
			return activeOperator > 1;
		}

		// Properties
		public decimal A
		{
			get { return a; }
			set { a = value; }
		}

		public decimal B
		{
			get { return b; }
			set { b = value; }
		}

		public char ActiveOperator
		{
			get { return activeOperator; }
			set { activeOperator = value; }
		}

		public bool AnyMinMemStore()
		{
			return MinMemStore.Any();
		}

		public bool AnyPlusMemStore()
		{
			return PlusMemStore.Any();
		}

		public void RemoveMemory()
		{
			MinMemStore = new List<decimal>();
			PlusMemStore = new List<decimal>();
		}

		public decimal MinMemStoreLast()
		{
			return MinMemStore.Last();
		}
		public decimal PlusMemStoreLast()
		{
			return PlusMemStore.Last();
		}
	}
}
