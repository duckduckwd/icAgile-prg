using System;
using Xunit;
using IncomeCalc;
using Moq;

namespace TestIncomeCalc
{

    public class IncomeCalculatorTest
    {

        private IncomeCalculator calc;
        public IncomeCalculatorTest()
        {
            calc = new IncomeCalculator();
        }
        [Fact]
        public void IncomeCalculator_ThrowsException_WhenNoCalcMethodIsSet()
        {
            calc = new IncomeCalculator();
            calc.Position = Position.SURFER;
            // TODO 1: Check calc.Calc() throws Exception when CalcMethod is not set
        }
        [Fact]
        public void IncomeCalculator_ReturnsExpectedResult_WhenPositionIsSupplied()
        {

            var mockDep = new Mock<ICalcMethod>();
            /* TODO 2
             Use the Setup method with a lambda to mock the calc method of ICalclMethod
             eg to mock an Add method of an ICalculate interface I might write :
             mockDep.Setup(m=> m.Add("").Returns(0));
             mockDep.Setup(m=> m.Add("1,2").Returns(3));
             */

            calc = new IncomeCalculator();
            // TODO 3: Inject your mock object
            //calc.CalcMethod = mockDep.Object;
            calc.Position = Position.BOSS;
            // TODO 4: Write an Assert to test 

            calc.Position = Position.PROGRAMMER;
            // TODO 5: Write an Assert to test 

        }
        [Fact]
        public void IncomeCalculator_ThrowsException_WhenExpected()
        {

            var mockDep = new Mock<ICalcMethod>();
            // TODO 6: Use a Setup to Throw an Exception when Position.SURFER is passed
            // HINT: Use Throws<>

            calc = new IncomeCalculator();
            calc.Position = Position.SURFER;
            calc.CalcMethod = mockDep.Object;
            Assert.Throws<Exception>(() => calc.Calc());

        }

        [Fact]
        public void IncomeCalculator_ThrowsException_WhenNoPositionIsSet()
        {
            //TODO 7: Implement Test!
        }
    }

}
