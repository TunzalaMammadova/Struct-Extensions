using System;
using System.Text.RegularExpressions;



namespace Extentions_Struct_Nullable.Homework.Helpers.Extentions
{
	public static class BaseExtentions
	{
		public static bool CheckEmail(this string str)
		{
			int count = 0;
			bool result = false;

			foreach (var item in str)
			{
				if (item == '@')
				{
					count++;
				}
			}

			if (count == 1)
			{
				result = true;
			}
				
            return result;

        }


		public static bool CheckTrimEmail(this string text, string pattern)
		{
            return Regex.IsMatch(text, pattern);
        }


		public static int GetMultiplyNumbers (this int[] numbers)
		{
			int multiply = 1;

			for (int i = 1; i < numbers.Length; i++)
			{
				 multiply *= numbers[i];
			}

			return multiply;

		}		
				
	}

}

