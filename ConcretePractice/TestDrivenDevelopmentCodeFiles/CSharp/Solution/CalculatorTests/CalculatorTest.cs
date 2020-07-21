using System;
using CalculatorLib;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTest
    {


        [Fact]
        public void SubtractionTest()
        {

        }
		[Fact]
	    public void subtractTest()
		{
			var calculator = new Calculator();
			int expected = 2;
			int actual = calculator.Subtract("5,3");
			Assert.Equal<int>(expected, actual);
		}

		[Fact]
	    public void subtract2Test()
		{
			var calculator = new Calculator();
			int expected = -8;
			int actual = calculator.Subtract("-5,3");
			Assert.Equal<int>(expected, actual);
		}

		[Fact]
	    public void subtract3Test()
		{
			var calculator = new Calculator();
			int expected = 2;
			int actual = calculator.Subtract("4,2");
			Assert.Equal<int>(expected, actual);
		}

		[Fact]
	    public void divide()
		{
			var calculator = new Calculator();
			int expected = 5;
			int actual = calculator.Divide("10,2");
			Assert.Equal<int>(expected, actual);
		}
		[Fact]
	    public void divide2()
		{
			var calculator = new Calculator();
			int expected = -5;
			int actual = calculator.Divide("10,-2");
			Assert.Equal<int>(expected, actual);
		}
		[Fact]
	    public void multiply()
		{
			var calculator = new Calculator();
			int expected = 50;
			int actual = calculator.Multiply("25,2");
			Assert.Equal<int>(expected, actual);
		}
		[Fact]
	    public void multiply2()
		{
			var calculator = new Calculator();
			int expected = 600;
			int actual = calculator.Multiply("150,4");
			Assert.Equal<int>(expected, actual);
		}

		
    	public void dividewithsomeexception()
		{
			var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(()=>calculator.Divide("10,0"));
		}

	}
}
