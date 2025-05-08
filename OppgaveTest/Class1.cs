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


public class twoValues
{
    public int compareNumbers = 15;
    public int compareNumbers2 = 15;

    public void Run()
    {
        Console.WriteLine(IsValueSame(compareNumbers, compareNumbers));
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