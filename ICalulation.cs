using System;
namespace Lesson6
{
	public interface ICalulation
	{
		public void Sum(double number);
		public void Subctruct(double number);
        public void Divide(double number);
        public void Multiply(double number);
        public void CanceLast();
        event EventHandler<OperandChangeCalculator> GotResult;
		
    }
}

