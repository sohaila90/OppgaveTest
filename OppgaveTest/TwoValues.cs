namespace OppgaveTest;

public class TwoValues
{
    
        public int CompareNumbers = 15;
        public int CompareNumbers2 = 15;

        public void Run()
        {
            Console.WriteLine(IsValueSame(CompareNumbers, CompareNumbers2));
        }

        private bool IsValueSame(int compnum1, int compnum2)
        {
            if (compnum1 == compnum2)
            {
                return true;
            }
            else
            {
                return false;
            }
       
        }
    }
