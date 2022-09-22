using System;

namespace homework2
{
	class Program
	{
		static bool CheckNumber(string s) //Функция для проверки строки на содержание символов(для преобразования в число)
		{
			foreach (char item in s) //Цикл для поочередного обращения к элементам строки
			{
				if (item != ',')
				{
					if (char.IsDigit(item) == false) // IsDigit функция определяет относится ли символ к категории чисел
					{
						return true;
					}
				}
			}
			return false;
		}
		static double Segment1(double x, double R)
		{
			double y = -R * Math.Sin(Math.Acos((x + 7) / R)) + 2;
			return y;
		}
		static double Segment2(double x)
        {
			double y = 2;
			return y;
        }
		static double Segment3(double x)
		{
			double y = -x * 0.5;
			return y;
		}
		static double Segment4(double x)
		{
			double y = Math.Sin(x);
			return y;
		}
		static double Segment5(double x)
        {
			double y = x - Math.PI;
			return y;
        }
		static void Main(string[] args)
		{
			Console.Write("Введите радиус(если число дробное, вводить через запятую): ");
			string r = Console.ReadLine();
			while (CheckNumber(r))
			{
				Console.Write("\nОшибка. Введите число: ");
				r = Console.ReadLine();
			}
			Console.Write("\n");
			double R = Convert.ToDouble(r);

			for (double x = -9; x <= 5; x += 0.2)
            {
				x = Math.Round(x, 2);
				if (x >= -9 && x < -5)
				{
					if (Convert.ToString(Segment1(x, R)) == "не число")
					{
						Console.Write("y({0:0.00}) = Функция не определена\n", x);
                    }
                    else
                    {
						Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x, R));
					}
				}
				else if (x >= -5 && x < -4)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x));
				}
				else if (x >= -4 && x < 0)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x));
				}
				else if (x >= 0 && x < Math.PI)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
				}
				else if (x >= Math.PI && x <= 5)
				{
					Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment5(x));
				}
			}
		}
	}
}
