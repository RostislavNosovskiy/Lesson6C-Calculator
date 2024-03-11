using System;
using System.Collections;
namespace Lesson6;

public class Calculator : ICalulation
{

    public event EventHandler<OperandChangeCalculator> GotResult;
    private double Result
    {
        get
        {
            return result.Count == 0 ? 0 : result.Peek();
        }
        set
        {
            result.Push(value);
            RiseEvent();
        }
    }

    private Stack<Double> result = new Stack<double>();
    public void RiseEvent()
    {
        GotResult.Invoke(this, new OperandChangeCalculator(Result));
    }
    public void CanceLast()
    {
        if (result.Count > 0)
        {
            result.Pop();
            RiseEvent();
        }
    }

    public void Divide(double number)
    {
        checked
        {
            if (number == 0)
            {
                throw new CalculatorDriveByZeroExeption("Деление на ноль недопустимо");
            }
            else if (Result / number < double.MaxValue && Result / number > double.MinValue)
            {
                Result /= number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (double)");
            }
        }
    }

    public void Divide(int number)
    {
        checked
        {
            if (number == 0)
            {
                throw new CalculatorDriveByZeroExeption("Деление на ноль недопустимо");
            }
            else if (Result / number < int.MaxValue && Result / number > int.MinValue)
            {
                Result /= number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (int)");
            }
        }
    }



    public void Multiply(double number)
    {
        checked
        {
            if (Result * number < double.MaxValue && Result * number > double.MinValue)
            {
                Result *= number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (double)");
            }
        }

    }

    public void Multiply(int number)
    {
        checked
        {
            if (Result * number < int.MaxValue && Result * number > int.MinValue)
            {
                Result *= number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (int)");
            }
        }

    }

    public void Subctruct(double number)
    {
        checked
        {
            if (Result - number > double.MinValue && Result - number < double.MaxValue)
            {
                Result -= number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (double)");
            }
        }
    }

    public void Subctruct(int number)
    {
        checked
        {
            if (Result - number > int.MinValue && Result - number < int.MaxValue)
            {
                Result -= number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (int)");
            }
        }
    }

    public void Sum(double number)
    {
        checked
        {
            if (Result + number > double.MinValue && Result + number < double.MaxValue)
            {
                Result += number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (double)");
            }
        }
    }

    public void Sum(int number)
    {
        checked
        {
            if (Result + number > int.MinValue && Result + number < int.MaxValue)
            {
                Result += number;
            }
            else
            {
                throw new CalculatorOperationCauseOwerflowExeption("Превышено допустимое значение числа (int)");
            }
        }
    }


}