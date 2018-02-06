using Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Collections;


namespace HomeTask1
{
	class Program
	{
		static void Main(string[] args)
		{

			string configExecuteValue = ConfigurationSettings.AppSettings.Get("execute_option");
			string configSourceValue = ConfigurationSettings.AppSettings.Get("resource_option");	  
			 

			if ("method".Equals(configExecuteValue))
			{

				int number1, number2;

				 
				Console.WriteLine("Enter the first number: ");
				Int32.TryParse(Console.ReadLine(), out number1);
				Console.WriteLine("Enter the second number: ");
				Int32.TryParse(Console.ReadLine(), out number2);
				Console.WriteLine("The sum of two numbers is: " + countSum(number1, number2));

			}

			else
			{
				int number3, number4;

				Console.WriteLine("Enter the first number: ");
				Int32.TryParse(Console.ReadLine(), out number3);
				Console.WriteLine("Enter the second number: ");
				Int32.TryParse(Console.ReadLine(), out number4);

				Console.WriteLine("\n" + "Sum: " + Arithmetic.sumTwoNumbers(number3, number4) + "\n");
				Console.WriteLine("Sum: " + Arithmetic.subTwoNumbers(number3, number4) + "\n");
				Console.WriteLine("Sum: " + Arithmetic.multTwoNumbers(number3, number4) + "\n");
				Console.WriteLine("Sum: " + Arithmetic.divTwoNumbers(number3, number4) + "\n");
			}
		}

		public static int countSum(int num1, int num2)
		{
			return (num1 + num2);
		}

	}
}
