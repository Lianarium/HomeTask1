using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	class DivideTest
	{

		[SetUp]
		public void setUp()
		{
			Console.WriteLine("Test setup");
		}

		[TestCase(10, 2, 5)]
		[TestCase(10, -2, -5)]
		[TestCase(10, 0.5, 20)]
		[TestCase(10, -0.5, -20)]
		[TestCase(2, 0, double.NaN)]
		[TestCase(null, null, null)]
		[TestCase(5, double.PositiveInfinity, double.NaN)]
		[TestCase(5, double.NegativeInfinity, double.NaN)]
		[TestCase("8", "2", 4)]
		[Test]
		public void divideTest(double num1, double num2, double expected)
		{
			//arrange
			Calculator calc = new Calculator();
			//act
			double actual = calc.Divide(num1, num2);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[TearDown]
		public void cleanUp()
		{
			Console.WriteLine("Test cleanup");
		}
	}
}
