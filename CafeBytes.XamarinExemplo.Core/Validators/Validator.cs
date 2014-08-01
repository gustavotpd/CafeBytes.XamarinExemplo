using System;
using System.Text.RegularExpressions;

namespace CafeBytes.XamarinExemplo.Core
{
	public static class Validator
	{
		public static  bool IsValidEmail(this string strIn)
		{
			return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
		}
	}
}

