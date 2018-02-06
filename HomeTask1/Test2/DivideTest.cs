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
		[TestCase(2, 0, null)]
		[TestCase(null, null, null)]
		[TestCase("8", "2", 4)]
		[Test]
		public void divideTest(int num1,int num2, int expected)
		{
			 
			//act
			double actual = Arithmetic.divTwoNumbers(num1, num2);
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
