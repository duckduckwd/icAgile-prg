using System;
using System.Threading;
using System.Text.RegularExpressions;

namespace CalculatorLib
{
	public static class Utils
	{ // stop class being inherited


		public static int ToNumber(String s)
		{
			return int.Parse(s);
		}

		public static bool IsNumeric(String str)
		{
			var exp = new Regex("[+-]?\\d*(\\.\\d+)?");
			return exp.IsMatch(str);
		}

		public static char ValidSeperator(String s)
		{  // example of a slow method
			int index = 0;
			while (char.IsDigit(s[index]))
				index++;
			try
			{
				Thread.Sleep(1000);
			}
			catch (Exception)
			{
			}
			return s[index];
		}

		// 
	}
}
