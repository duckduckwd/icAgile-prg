using System;

namespace IncomeCalc
{

    public class IncomeCalculator
    {
        private ICalcMethod calcMethod;
        private Position? position;

        public ICalcMethod CalcMethod
        {
            set => this.calcMethod = value;

        }

        public Position? Position
        {
            set => this.position = value;
            get => this.position;
        }

        public double Calc()
        {
            if (calcMethod == null)
            {
                throw new Exception("CalcMethod not yet maintained");
            }
            if (position == null)
            {
                throw new Exception("Position not yet maintained");
            }
            return calcMethod.calc(position.Value);
        }
    }
}