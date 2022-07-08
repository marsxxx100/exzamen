using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_v_1
{
	public static class Calculator
	{
		public const string CalculateDivisionByZeroMessage = "Деление целого числа на ноль";
		public static int Sum(int a, int b)
		{
			return a + b;
		}

		public static double Sum(double a, double b)
		{
			return a + b;
		}

		public static int Difference(int a, int b)
		{
			return a - b;
		}

		public static double Difference(double a, double b)
		{
			return a - b;
		}

		public static int Product(int a, int b)
		{
			return a * b;
		}

		public static double Product(double a, double b)
		{
			return a * b;
		}

		public static int Division(int a, int b)
		{
			return a / b;
		}

		public static double Division(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException(CalculateDivisionByZeroMessage);
			}
			return a / b;
		}
	}
}
