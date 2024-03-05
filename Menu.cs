using System;
namespace Lesson6
{
    public class Menu
    {
        private static string frame = new string('-', 40);
        private string menu = $"{frame}\n|Выберите действие:\n{frame}\n" +
                    $"|1. Сложение \n{frame}\n" +
                    $"|2. Вычитание\n{frame}\n" +
                    $"|3. Деление\n{frame}\n" +
                    $"|4. Умножение\n{frame}\n" +
                    $"|5. Отменить последнее действие\n{frame}\n" +
                    $"|6. Закончить работу калькулятора\n{frame}\n";
        private bool work = true;

        public void Start(Calculator calculator)
        {
            while (work)
            {
                Console.WriteLine(menu);
                string? choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        calculator.Sum(GetNumFromUser());
                        break;
                    case "2":
                        calculator.Subctruct(GetNumFromUser());
                        break;
                    case "3":
                        calculator.Divide(GetNumFromUser());
                        break;
                    case "4":
                        calculator.Multiply(GetNumFromUser());
                        break;
                    case "5":
                        calculator.CanceLast();
                        break;
                    case "6":
                        Console.WriteLine("До новых встреч!)");
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Неправильно введена команда");
                        break;
                }

            }
        }
        public int GetNumFromUser()
        {
            Console.WriteLine("Введите число");
            string? numInStr = Console.ReadLine();
            if (int.TryParse(numInStr, out int num))
            {
                return num;
            }
            return 0;
        }

	}
}

