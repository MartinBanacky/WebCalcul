using Microsoft.AspNetCore.Components.Web;

namespace WebCalcul.Data
{
    public class Calcul
    {
        public string input = string.Empty;
        public string output = string.Empty;
        public string result = string.Empty;
        public string info = string.Empty;
        public bool operatorActive = false;
        public char operatorChar = '\0';
        public float numA;
        public float numB;



        public float ApplyOperand(float a, float b, char operand)
        {
            switch (operand)
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

        public float StringToFloat(string input)
        {
            float outputFloat = 0;
            try
            {
                outputFloat = float.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
                return 0;
            }
            return outputFloat;
        }

        public void ExecuteExpression(ref float numberA, ref float numberB, bool operatorActiveSign, string inputField, char operatorCharacter)
        {
            var numBUncut = string.Empty;
            numBUncut += inputField;
            if (operatorActiveSign)
            {
                numBUncut = numBUncut.Remove(numBUncut.Length - 1);
            }

            numberB = StringToFloat(numBUncut);
            numberA = ApplyOperand(numberA, numberB, operatorCharacter);
        }


        public void ClearEnd(MouseEventArgs e)
        {
            RemoveLastCharacter(input, out input);
        }

        /// <summary>
        /// Remove last character from input
        /// </summary>
        public void RemoveLastCharacter(string input, out string output)
        {
            output = string.Empty;
            if (!string.IsNullOrEmpty(input))
            {
                output = input.Remove(input.Length - 1);
            }
        }

        /// <summary>
        /// Check if last character was not number or bracket.
        /// </summary>
        public bool RewriteOperator(char lastChar)
        {
            // return lastChar != 40 && lastChar != 41 && lastChar < 48 || lastChar > 57;
            return lastChar < 48 || lastChar > 57;
        }

        /// <summary>
        /// Check if last character have to be rewritten. If true, rewrite it.
        /// </summary>
        public void CheckLastChar(char lastChar)
        {
            if (RewriteOperator(lastChar)) { info = "operator changed"; RemoveLastCharacter(input, out input); }
        }
    }
}
