namespace WebCalcul.Data
{
	public class CalculState
	{

		public int Id { get; set; } //PK
		public decimal NumberA { get; set; }
		public decimal NumberB { get; set; }
		public char Operator { get; set; }
		public decimal Result { get; set; }

		public bool OperatorActiveSign { get; set; } = false;
		public bool ResultIterationSign { get; set; } = false;
		public bool PercentageIterationSign { get; set; } = false;
		public bool MemoryActiveSign { get; set; } = false;
		public bool RewriteInputSign { get; set; } = true;

		public CalculState()
		{
		}

		public void SaveStateBeforeExec(Calcul calcul, bool OperActiveSign, bool ResultIterSign, bool PercentIterSign, bool MemActiveSign, bool RwrtInputSign)
		{
			NumberA = calcul.A;
			NumberB = calcul.B;
			Operator = calcul.ActiveOperator;
			OperatorActiveSign = OperActiveSign;
			ResultIterationSign = ResultIterSign;
			PercentageIterationSign = PercentIterSign;
			MemoryActiveSign = MemActiveSign;
			RewriteInputSign = RwrtInputSign;
		}

		public void UpdateStateResultAfterExec(decimal result)
		{
			Result = result;	
		}
	}
}
