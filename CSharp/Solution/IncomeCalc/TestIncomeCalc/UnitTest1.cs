using System;
using Xunit;
using IncomeCalc;
using Moq;

namespace TestIncomeCalc
{

    public class IncomeCalculatorTest
    {

        private ICalcMethod calcMethod;
        private IncomeCalculator calc;


        public IncomeCalculatorTest()
        {
            // NiceMocks return default values for unimplemented methods
            calc = new IncomeCalculator();
        }
        [Fact]
        public void testCalc1()
        {

            var mockDep = new Mock<ICalcMethod>();
            mockDep.Setup(m => m.calc(Position.BOSS)).Returns(70000.0);
            mockDep.Setup(m => m.calc(Position.PROGRAMMER)).Returns(50000.0);

            calc = new IncomeCalculator();
            calc.CalcMethod = mockDep.Object;
            Assert.Throws<Exception>(() => calc.Calc());

            calc.Position = Position.BOSS;
            Assert.Equal(70000.0, calc.Calc());

            calc.Position = Position.PROGRAMMER;
            Assert.Equal(50000.0, calc.Calc());
        }
        [Fact]
        public void testNoCalc()
        {
            calc.Position = Position.SURFER;
            Assert.Throws<Exception>(() => calc.Calc());
        }
        [Fact]
        public void testNoPosition()
        {
            var mockDep = new Mock<ICalcMethod>();
            mockDep.Setup(m => m.calc(Position.BOSS)).Returns(70000.0);

            calc = new IncomeCalculator();
            calc.CalcMethod = mockDep.Object;
            Assert.Throws<Exception>(() => calc.Calc());

        }
        [Fact]
        public void testCalc2()
        {

            var mockDep = new Mock<ICalcMethod>();
            mockDep.Setup(m => m.calc(Position.SURFER)).Throws<Exception>();

            calc = new IncomeCalculator();
            calc.Position = Position.SURFER;
            calc.CalcMethod = mockDep.Object;
            Assert.Throws<Exception>(() => calc.Calc());

        }
    }

}
