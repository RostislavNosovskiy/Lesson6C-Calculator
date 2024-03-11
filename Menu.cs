using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Lesson6
{
    public class Menu
    {
        private static string frame = new string('-', 40);
        private string menu = $"{frame}\n|Выберите действие:\n{frame}\n" +
                    $"|+. Сложение \n{frame}\n" +
                    $"|-. Вычитание\n{frame}\n" +
                    $"|/. Деление\n{frame}\n" +
                    $"|*. Умножение\n{frame}\n" +
                    $"|cl. Отменить последнее действие\n{frame}\n" +
                    $"|q. Закончить работу калькулятора\n{frame}\n";
        private bool work = true;
        

        public void Start(Calculator calculator)
        {
             Loger loger = new Loger();
            while (work)
            {
                try
                {
                    Console.WriteLine(menu);
                    string? choise = Console.ReadLine();
                    Console.WriteLine("Введите число");
                    string? numInString = Console.ReadLine();
                    if(Int32.TryParse(numInString, out int number)) {
                        Console.WriteLine(number.GetType());
                        loger.AddLog(number, choise);
                        switch (choise)
                        {
                            case "+":
                                calculator.Sum(number);
                                break;
                            case "-":
                                calculator.Subctruct(number);
                                break;
                            case "/":
                                calculator.Divide(number);
                                break;
                            case "*":
                                calculator.Multiply(number);
                                break;
                            case "cl":
                                calculator.CanceLast();
                                break;
                            case "q":
                                Console.WriteLine("До новых встреч!)");
                                work = false;
                                break;
                            default:
                                Console.WriteLine("Неправильно введена команда");
                                break;
                        }
                    }else if(Double.TryParse(numInString, out double numberDouble))
                    {
                        Console.WriteLine(numberDouble.GetType());
                        loger.AddLog(numberDouble, choise);
                        switch (choise)
                        {
                            case "+":
                                calculator.Sum(numberDouble);
                                break;
                            case "-":
                                calculator.Subctruct(numberDouble);
                                break;
                            case "/":
                                calculator.Divide(numberDouble);
                                break;
                            case "*":
                                calculator.Multiply(numberDouble);
                                break;
                            case "cl":
                                calculator.CanceLast();
                                break;
                            case "q":
                                Console.WriteLine("До новых встреч!)");
                                work = false;
                                break;
                            default:
                                Console.WriteLine("Неправильно введена команда");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неправильно введено число");
                    }

                }
                catch(CalculatorDriveByZeroExeption e)
                {
                    Console.WriteLine(e.Message + loger.GetLog());
                }
                catch (CalculatorOperationCauseOwerflowExeption e)
                {
                    Console.WriteLine(e.Message + loger.GetLog());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + loger.GetLog());
                }
                

            }
        }
         

	}
}

