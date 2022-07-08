using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_v_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("--Калькулятор--");
			while (true)
			{
				Console.Write("\nМеню:\n" +
					" 1. Сумма двух чисел;\n" +
					" 2. Разность двух чисел;\n" +
					" 3. Произведение двух чисел;\n" +
					" 4. Деление двух чисел;\n" + 
					" 5. Выход.\n>");
				string line = Console.ReadLine();
				if (line == "1")
				{
					Console.WriteLine("Сумма двух чисел.");
					Console.Write("Введите первое слагаемое: ");
					double a = double.Parse(Console.ReadLine());
					Console.Write("Введите второе слагаемое: ");
					double b = double.Parse(Console.ReadLine());
					double result = Calculator.Sum(a, b);
					PrintResult($"Сумма чисел {a} и {b}: {result}");
				}
				else if (line == "2")
				{
					Console.WriteLine("Разность двух чисел.");
					Console.Write("Введите уменьшаемое: ");
					double a = double.Parse(Console.ReadLine());
					Console.Write("Введите вычитаемое: ");
					double b = double.Parse(Console.ReadLine());
					double result = Calculator.Difference(a, b);
					PrintResult($"Разность чисел {a} и {b}: {result}");
				}
				else if (line == "3")
				{
					Console.WriteLine("Произведение двух чисел.");
					Console.Write("Введите первый множитель: ");
					double a = double.Parse(Console.ReadLine());
					Console.Write("Введите второй множитель: ");
					double b = double.Parse(Console.ReadLine());
					double result = Calculator.Product(a, b);
					PrintResult($"Произведение чисел {a} и {b}: {result}");
				}
				else if (line == "4")
				{
					Console.WriteLine("Деление двух чисел.");
					Console.Write("Введите делимое: ");
					double a = double.Parse(Console.ReadLine());
					Console.Write("Введите делитель: ");
					double b = double.Parse(Console.ReadLine());
					try
					{
						double result = Calculator.Division(a, b);
						PrintResult($"Частное чисел {a} и {b}: {result}");
					}
					catch (DivideByZeroException e)
					{
						PrintError(e.Message);
					}
				}
				else if (line == "5")
				{
					Console.WriteLine("Выход...");
					break;
				}
				else
				{
					PrintError("Такой команды нет");
				}
			}
		}
		private static void PrintError(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}

		private static void PrintResult(string message)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
