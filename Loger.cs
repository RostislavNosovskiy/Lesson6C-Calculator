using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson6
{
	public class Loger
	{
		private Stack<(double, string)> log = new Stack<(double, string)>();

        public void AddLog(double number, string operation)
        {
            log.Push(new(number, operation));
        }

        public string GetLog()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" StackTrace: ");
            foreach (var log in log)
            {
                sb.Append(log.ToString());
            }
            return sb.ToString();
        }
    }

	
}

