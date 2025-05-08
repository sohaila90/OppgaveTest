namespace OppgaveTest;

public class Class2
{
    private int _diffNumber1 = 10;
    private int _diffNumber2 = 20;

    public void Run()
    {
        Console.WriteLine(IsNumberSame(_diffNumber1, _diffNumber2));
    }

    private int IsNumberSame(int diffnum1, int diffnum2)
    {
        if (diffnum1 == diffnum2)
        {
            return diffnum1 + diffnum2;
        }
        else
        {
            return diffnum1 * diffnum2;
        }
    }
}