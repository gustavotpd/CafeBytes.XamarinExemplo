using System;

namespace CafeBytes.XamarinExemplo.Contract
{
	public class Person
	{
		public Person (string name, string email)
		{
			Name = name;
			Email = email;
		}

		public string Name { get; set;}
		public string Email { get; set;}
	}
}
