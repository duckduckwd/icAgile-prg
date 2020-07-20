using System;
using CalculatorLib;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTestShared
    {
		Calculator calculator;


        public CalculatorTestShared()
        {
			calculator = new Calculator();
        }

        [Fact]
        public void SubtractionTest()
        {

        }
		[Fact]
	    public void subtractTest()
		{
			calculator = new Calculator();
			int expected = 2;
			int actual = calculator.Subtract("5,3");
			Assert.Equal<int>(expected, actual);
		}

		[Fact]
	    public void subtract2Test()
		{
			calculator = new Calculator();
			int expected = -8;
			int actual = calculator.Subtract("-5,3");
			Assert.Equal<int>(expected, actual);
		}

		[Fact]
	    public void subtract3Test()
		{
			calculator = new Calculator();
			int expected = 2;
			int actual = calculator.Subtract("4,2");
			Assert.Equal<int>(expected, actual);
		}

		[Fact]
	    public void divide()
		{
			calculator = new Calculator();
			int expected = 5;
			int actual = calculator.Divide("10,2");
			Assert.Equal<int>(expected, actual);
		}
		[Fact]
	    public void divide2()
		{
			calculator = new Calculator();
			int expected = -5;
			int actual = calculator.Divide("10,-2");
			Assert.Equal<int>(expected, actual);
		}
		[Fact]
	    public void multiply()
		{
			calculator = new Calculator();
			int expected = 50;
			int actual = calculator.Multiply("25,2");
			Assert.Equal<int>(expected, actual);
		}
		[Fact]
	    public void multiply2()
		{
			calculator = new Calculator();
			int expected = 600;
			int actual = calculator.Multiply("150,4");
			Assert.Equal<int>(expected, actual);
		}

		
    	public void dividewithsomeexception()
		{
			calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(()=>calculator.Divide("10,0"));
		}

	}
}
