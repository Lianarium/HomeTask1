using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace Test
{
	[TestClass]
	public class AddTests
	{
		[ClassInitialize()]
		public static void ClassSetup(TestContext content)
		{
			Console.WriteLine("Test Class AddTest is started");
		}

		[TestInitialize()]
		public void TestSetup()
		{
			Console.WriteLine("Unit Test(s) are started");

		}

		[TestMethod]
		public void addTwoPositiveNumbers()
		{
			//arrange
			int expected = 17;

			//act
			int actual = Arithmetic.sumTwoNumbers(12, 5);

			//assert
			Assert.AreEqual(expected, actual);
		}



		[TestMethod]
		public void addPositiveNumberToNegative()
		{
			//arrange
			int expected = 7;

			//act
			int actual = Arithmetic.sumTwoNumbers(12, -5);

			//assert
			Assert.AreEqual(expected, actual);
		}



		[TestMethod]
		public void maxValuePlusSmallNumber()
		{
			//arrange

			//act
			double actual = Arithmetic.sumTwoNumbers(Int32.MaxValue, 1*(10^10));

			//assert
			Assert.AreEqual(null, actual);

		}

		[TestMethod]
		public void maxValuePlusBigNumber()
		{
			//act
			double actual = Arithmetic.sumTwoNumbers(Int32.MaxValue, 1*(10^308));
			Console.WriteLine(actual);
			Assert.AreEqual(null, actual);

		}

      [ClassCleanup()]
		public static void ClassCleanup()
		{
			Console.WriteLine("Test Class AddTest is finished");
		}

	}
}
