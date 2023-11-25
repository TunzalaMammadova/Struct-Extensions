
using Extentions_Sturct_Nullable.Practice;
using Extentions_Sturct_Nullable.Practice.Helpers.Extentions;

//int number = 100;

//number.ShowNum();

//int number3 = 6;

//number3.ShowNum();

//int num1 = 50;
//num1.ShowNum(30);

//int num1 = 6;
//int num2 = 100;
//int res = num1.SumOfNums(num2);

//Console.WriteLine(res);



//string str = "Salam Rufet bey, ";
//var result = str.ShowText("Niye hazirlasmirsiniz ?");

//Console.WriteLine(result);



//string text = "salam2";
//var res = text.ChechDigitForStr();



//if (res)
//{
//    Console.WriteLine("Have digit");
//}
//else
//{
//    Console.WriteLine("Havent digit");
//}



//string email = "tunzale@gmail.com";

//Console.WriteLine(email.ChechkEmail());



//string email = "tunzale@gmail.com";

//Console.WriteLine(email.CheckStr("@"));
//Console.WriteLine(email.CheckStr(@"\d"));
//Console.WriteLine(email.CheckStr(@"[A-Z]"));
//Console.WriteLine(email.CheckStr(@"[A-Za-z]"));



//Person person1 = new("semed@gmail.com");
//Person person2 = new("semedgmail.com");
//Person person3 = new("semedgmailcom");



//int num = 4;
//var res = num.FindFactorial();

//Console.WriteLine(res);



//Console.WriteLine("Please add your email");
//Email: string email = Console.ReadLine();

//if (!email.CheckEmailAndPassword("@"))
//{
//    Console.WriteLine("Email incorrect");
//    goto Email;
//}


//Console.WriteLine("Please add your password");
//Password: string password = Console.ReadLine();

//if (!password.CheckEmailAndPassword(@"\W"))
//{
//    Console.WriteLine("Password incorrect");
//    goto Password;
//}


//Console.WriteLine("Login sucess");



//int a = 10;

//Console.WriteLine(a.PowOfNum(3));



//string a = "code";
//Console.WriteLine(a.IsConvertStringToNumber());

//string b = "5";
//Console.WriteLine(b.IsConvertStringToNumber());



//Car car = new();
//car.name = "Tunzale";

//Console.WriteLine(car.name);


//Car car;
//car.name = "Tunzale";


//Console.WriteLine(car.name);


//string name = null;

//if (name is null)
//{
//    Console.WriteLine("Not found");
//}



//int? age = null;

//Console.WriteLine(age);




//static void CreateData(string name, string surname, int? age)
//{
//    if (name == null || surname == null || age == null)
//    {
//        Console.WriteLine("Please fill all inputs");
//        return;
//    }

//    Console.WriteLine(name + "-" + surname + "-" + age);
//}


//CreateData("Tunzale", "Memmedova", null);


//static void Test(User user)
//{
//    Console.WriteLine(user.Weight);
//}


//static void Register(User user)
//{
//    if (user.FullName != null && user.Email != null && user.Password != null)
//    {
//        Console.WriteLine("Register success");
//    }
//    else
//    {
//        Console.WriteLine("Register failed");
//    }



//}


//Register(new User { Id = 1, FullName = "Tunzale", Email = "tunzale@gmail.com", Password = "12345" });






//static void CheckRegister(User user)
//{
//    if (!string.IsNullOrEmpty(user.Email.Trim()) && !string.IsNullOrEmpty(user.FullName) && !string.IsNullOrEmpty(user.Password))
//    {
//        Console.WriteLine("Register success");
//    }
//    else
//    {
//        Console.WriteLine("Register failed");
//    }



//}


//Register(new User { Id = 1, FullName = "Tunzale", Email = "  tunzale@gmail.com", Password = "12345" });