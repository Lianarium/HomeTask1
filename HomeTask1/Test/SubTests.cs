using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	[TestClass]
	public class SubTests
	{
		[ClassInitialize()]
		public static void ClassSetup(TestContext content)
		{
			Console.WriteLine("Test Class SubTest is started");
		}

		[TestInitialize()]
		public void TestSetup()
		{
			Console.WriteLine("Unit Test(s) are started");

		}
		//arrange
		int num1 = 100;
		int num2 = 15;

		[TestMethod]
		public void greaterPositiveDoubleMinusSmaller()
		{

			//act
			int actual = Arithmetic.subTwoNumbers(num1, num2);
			//assert
			Assert.AreEqual(85, actual);
		}

		[TestMethod]
		public void smallerPositiveDoubleMinusGreater()
		{
			//act
			double actual = Arithmetic.subTwoNumbers(num2, num1);
			//assert
			Assert.AreEqual(-85, actual);
		}


		[TestMethod]
		public void subtractNumberFromItself()
		{
			//act
			double actual = Arithmetic.subTwoNumbers(num2, num2);
			//assert
			Assert.AreEqual(0, actual);

		}


		[TestMethod]
		public void minValueMinusBigNumber()
		{
			//act
			double actual = Arithmetic.subTwoNumbers(int.MinValue, 1*(10^10));
			Console.WriteLine(actual);
			//assert
			Assert.AreEqual(null, actual);

		}

		[TestMethod]
		public void minValueMinusSmallNumber()
		{
			//act
			double actual = Arithmetic.subTwoNumbers(int.MinValue, -(1*(10^10)));
			Console.WriteLine(actual);
			//assert
			Assert.AreEqual(null, actual);

		}

		 [TestCleanup()]
		public void TestCleanup()
		{
			Console.WriteLine("Unit Test(s) are finished");

		}

		[ClassCleanup()]
		public static void ClassCleanup()
		{
			Console.WriteLine("Test Class SubTest is finished");
		}

	}
}
