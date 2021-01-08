using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class Test
	{
		static void Main()
		{
			Console.WriteLine("enter first number");
			string input = Console.ReadLine();
			double num1, num2;
			bool result = Double.TryParse(input, out num1);
			if (!result)
			{
				Console.WriteLine("enter a number");
				return;
			}
			Console.WriteLine("enter second number");
			
			 result = Double.TryParse(Console.ReadLine(), out num2);
			if (!result)
			{
				Console.WriteLine("enter a number");
				return;
			}
			Console.WriteLine("Enter Add,Divide");
		CalculateFactory factory = new CalculateFactory();
			ICalculate obj= factory.GetCalculate(Console.ReadLine());
			obj.Calculate(num1, num2);
			Main();

		}
	}
}
