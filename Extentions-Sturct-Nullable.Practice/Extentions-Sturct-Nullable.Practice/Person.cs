using System;
using Extentions_Sturct_Nullable.Practice.Helpers.Extentions;

namespace Extentions_Sturct_Nullable.Practice
{
	public class Person
	{
		public int Id { get; set; }
        public string Email { get; set; }

		public Person(string email)
		{
			Email = email;
			Console.WriteLine(Email.CheckStr("@"));
		}
    }
}

