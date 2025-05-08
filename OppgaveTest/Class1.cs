namespace OppgaveTest;

public class Class1
{
private int number1 = 2;
private int number2 = 3;
    
    public void Run()
    {
        Console.WriteLine(CheckNumber(number1, number2));
        
    }

    private bool CheckNumber(int num1, int num2)
    {
        if (num1 == num2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
