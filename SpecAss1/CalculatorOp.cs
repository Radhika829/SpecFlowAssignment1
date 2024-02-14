namespace SpecAss1
{
    public class CalculatorOp
    {
        
            private int _currentResult;
        //private int result;

            public void EnterNumber(int number)
            {
                _currentResult = number;
            }

            public int Multiply()
            {
                return _currentResult *= 2; // Assuming multiplication by 2 for simplicity
            }

            public int Subtract()
            {
                return _currentResult -= 2; // Assuming subtraction by 2 for simplicity
            }

            public int Divide()
            {
                return _currentResult /= 2; // Assuming division by 2 for simplicity
            }
        }
    }

