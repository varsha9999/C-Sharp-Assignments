// See https://aka.ms/new-console-template for more information
//int i = 0;
//for (; i<20 ; i++ )
//{

//   if (i == 15)
//   {
//        break;
//    }
//      Console.WriteLine(i);
//}

//switch

//string number = "one";
//switch (number)
//{
//    case "one":
//    case"ONE":
//        Console.WriteLine("number is one");
//        break;
//    case "two":
//    case "TWO":
//        Console.WriteLine("number is two");
//        break;
//    case "three":
//    case "THREE":
//        Console.WriteLine("number is three");
//        break;
//    default:
//        Console.WriteLine("number is not correct");
//        break;
//}
//int number = 1;
//string result = number switch
//{
//    1 => "number is 1",
//    2 => "number is 2",
//    3 => "number is 3",
//    _ => "number is not 1,2 or 3"
//};
//Console.WriteLine(result);

//object o= "hello";
//Console.WriteLine(o);
//Console.WriteLine(o.GetType());
//object[] data =
//{
//    1, 2, "three", 4,"five"
//};
//int sum = 0;

//foreach (object item in data)
//{
//    var typeOfItem = item.GetType();
//    if (typeOfItem == typeof(int))
//    {
//        sum += (int)item;
//    }
//}
//Console.WriteLine(sum);

//dynamic d = "hello";
//Console.WriteLine(d.ToUpper());
//int i = 10;
//object o = i;
//Console.WriteLine(o);
//int j = (int)o;
//Console.WriteLine(o);
//var obj = new
//{
//    name = "john doe",
//    email = "johndoe@mail.com"
//};
//Console.WriteLine(obj.name);
//string[] symbols = {"|","/","-",@"\","|"};
//for (int i = 0;i < 10; i++)
//{
//    for(int j = 0; j < symbols.Length;j++)
//    {
//        Console.Write("\r");
//        Thread.Sleep(1000);
//        Console.Write(symbols[j]);
//    }
//}

//void greet()
//{
//    Console.WriteLine("hello world");
//}
//greet();

//void add(int a,int b)
//{
//    Console.WriteLine(a+ b); 
//}
//int x = 22;
//int y = 22;
//add(x,y);

//int add(int a, int b)
//{
//   return a + b;
//}
//int result = add(2, 5);
//Console.WriteLine(result);


//string add(int a, int b)
//{
//    return (a + b).ToString();
//}
//string result = add(2, 5);
//Console.WriteLine(result);
//void ShowData (string name, string email = null)
//{
//    Console.WriteLine("name:" + name);
//    Console.WriteLine("email:" +email); 
//}
//ShowData("john");
//void ShowData(string name, string email = null , string phone = null)
//{
//    Console.WriteLine("name:" + name);
//    Console.WriteLine("email:" + email);
//    Console.WriteLine("phone:" + phone);
//}
//ShowData("john",phone:"3333333");

//using System.Security.Cryptography.X509Certificates;

//void Addition ( int x ,int y ,params int[] numbers)
//{
//    int sum = x + y;
//    foreach (int i in numbers)
//    {
//        sum += i;
//    }
//    Console.WriteLine("sum is :" + sum);
//}
//Addition(1, 2);
//Addition(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

//using ConsoleApp1;

//var s = new student()
//{
//    name = "john",
//    mark1 = 40,
//    mark2 = 45
//};

//Console.WriteLine(s.total());
//class student
//{
//    public string name;
//    public int mark1;
//    public int mark2;
//    public int total(){
//    return mark1 + mark2;
//    }
//}

//using ConsoleApp1;

//var p = new Person();
//p.Name = "john honai";
//p.mark1 = 67;
//p.mark2 = 40;
//Console.WriteLine(p.Total());

//Console.WriteLine("Enter a values:");
//string text = Console.ReadLine();
//int count = 0;
//foreach (char item in text)
//{

//    if (item >=  '0' && item <= '9' )
//    {
//count++;
//    }
//}
//if (count == 0)
//{
//    Console.WriteLine("no numbers found.");
//    Environment.Exit(0);
//}
//var numbers = new int[count];
//int ArrayIndex = 0;
//foreach (char item in text)
//{
//    if (item >= '0' && item <= '9')
//    {
//        numbers[ArrayIndex++] = int.Parse(item.ToString());
//    }
//}
//Console.WriteLine(string.Join(",",numbers));
DateTime dt = DateTime.Now;
//Console.WriteLine(dt);
//var dt1 = new DateTime(2002, 12, 12, 00, 00, 00);
//var dt2 = new DateTime(2023, 12, 12, 00, 00, 00);
//Console.WriteLine($"Timespan:{ts}");

