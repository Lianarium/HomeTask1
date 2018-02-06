using Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{

	[TestFixture]
	class MultiplyTest
	{

		[SetUp]
		public void setUp()
		{
			Console.WriteLine("Test setup");
		}

		[TestCase(4, 3, 12)]
		[TestCase(4, -3, -12)]
		[TestCase(-4, -5, 20)]
		[TestCase(22, 0, 0)]
		[TestCase(25, 1, 25)]
		[TestCase(null, null, null)]
		[TestCase("2", "2", 4)]
		[Test]
		public void multiplyTest(int num1, int num2, int expected)
		{
			 
			//act
			double actual = Arithmetic.multTwoNumbers(num1, num2);
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
