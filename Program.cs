namespace Lesson6;
class Program 
{
    public static void Main()
    {
        Calculator calculator = new Calculator();
    
        calculator.GotResult += Calculator_GotResult;
        //calculator.Sum(5);
        //calculator.CanceLast();
        Menu menu = new Menu();
        menu.Start(calculator);
    }

    private static void Calculator_GotResult(object? sender, OperandChangeCalculator e)
    {
        Console.WriteLine($"Резултат операции {e.Result}");
    }
    
}


   

