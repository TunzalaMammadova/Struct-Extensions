using System;
using System.Xml.Linq;

namespace Extentions_Struct_Nullable.Homework.Helpers.Extentions
{
	public class PersonExtentions
	{
        public static Person[] GetAll()
        {
            return new Person[]
            {
               new Person{Id = 1, Name = "Tunzale", Surname = "Memmedova"},
               new Person{Id = 2, Name = "Semed", Surname = "Huseynov"},
               new Person{Id = 3, Name = "Elnur", Surname = "Memmedov"},

            };
          
        }  

        public static void GetFullData()
        {
            var res = GetAll();
            foreach (var item in res)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
            
        }


     
	}
}

