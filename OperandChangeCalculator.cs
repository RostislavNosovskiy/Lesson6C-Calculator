using System;
namespace Lesson6
{
	public class OperandChangeCalculator : EventArgs 
	{
        public double Result { get; set; }
        public OperandChangeCalculator(double Res)
        {
            Result = Res;
        }
    }
}

