using System;
using System.Collections;
namespace Lesson6;
    
	public class Calculator : ICalulation
	{
		
        public event EventHandler<OperandChangeCalculator> GotResult;
        private double Result
        {
            get
            {
                return result.Count == 0 ? 0 : result.Peek();
            }
            set
            {
                result.Push(value);
                RiseEvent();
            }
        }

        private Stack<Double> result = new Stack<double>() ;
        public void RiseEvent()
        {
            GotResult.Invoke(this, new OperandChangeCalculator(Result));
        }
        public void CanceLast()
        {
            if (result.Count > 0)
            {
                result.Pop();
                RiseEvent();
            }
        }

        public void Divide(double number)
        {
             Result /= number;
        }

        public void Multiply(double number)
        {
             Result *= number;
        }

        public void Subctruct(double number)
        {
             Result -= number;
        }

        public void Sum(double number)
        {
             Result += number;
        }
    }


