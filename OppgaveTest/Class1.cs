namespace OppgaveTest;

public class Class1
{
private int _number1 = 2;
private int _number2 = 3;
    
    public void Run()
    {
        Console.WriteLine(CheckNumber(_number1, _number2));
        
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


