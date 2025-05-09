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