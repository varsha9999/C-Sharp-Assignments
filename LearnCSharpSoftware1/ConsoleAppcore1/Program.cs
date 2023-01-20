// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter 10 passenger names:");
//string[] arr = new string[3];
//for (int i = 0;i <3; i++)
//{
//    arr[i] = Console.ReadLine();
//}
//Console.WriteLine(string.Join(",", arr));
////for (int i = 0;i <arr.Length; i++)
////{
////    Console.WriteLine(arr[i]);
////}
//Console.WriteLine("-------");
//Console.WriteLine("sorting");
//Console.WriteLine("-------");
//Array.Sort(arr);
//foreach (string s in arr) 
//{ 
//    Console.WriteLine(s); 
//}
//Console.WriteLine("-------");
//Console.WriteLine("reverse sorting");
//Console.WriteLine("-------");
//Array.Reverse(arr);
//foreach (string s in arr) 
//{ 
//    Console.WriteLine(s); 
//}
//Console.WriteLine("-------");
//Console.WriteLine("searching");
//Console.WriteLine("-------");
//Console.WriteLine("Enter a name to search:");
//string name = Console.ReadLine();
//bool searchedName = arr.Contains(name);
////Console.WriteLine(searchedName);
//int flag = 0;
//for (int i = 0;i < arr.Length; i++)  
//{
//    for (int j = 0;i < arr.Length;i++) {
//        if (name == arr[i])
//        {

//            flag = 1;
//        } 

//    }

//}
//if (flag != 0)
//{
//    Console.WriteLine("name:" +name);
//}
//else
//{
//    Console.WriteLine("no such name");
//}
//Console.WriteLine("-------");
//Console.WriteLine("Length");
//Console.WriteLine("-------");

//foreach (string s in arr)
//{
//    Console.WriteLine(s+ ":" + s.Length);
//}
//Console.WriteLine("-------");
//Console.WriteLine("Split");
//Console.WriteLine("-------");
//for (int i = 0; i < arr.Length; i++)
//{
//    var splitedNames = arr[i].Split(' ');
//    Array.ForEach(splitedNames, s => Console.WriteLine(s));
//}
//Console.WriteLine("-------");
//Console.WriteLine("duplicate");
//Console.WriteLine("-------");
//var count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i+1; j < arr.Length; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            count++;
//            Console.Write(arr[i]);
//        }
//    }
//}
//if (count == 0)
//    Console.Write("no dupliacte values");

//Console.WriteLine("-------");
//Console.WriteLine("flight fare and booking time");
//Console.WriteLine("-------");

//Console.WriteLine("Enter flight fare :");
//string fare = Console.ReadLine();
//int n1 = Convert.ToInt32(fare);
//Console.WriteLine("Enter booking time  :");
//string bookingTime = Console.ReadLine();
//int n2 = Convert.ToInt32(bookingTime);
//if (n2>=6 && n2 <= 9)
//{
//    var flightFare = (n1*10/100)+n1;
//    Console.WriteLine("Flight Fare:"+flightFare);
//}
//else if (n2 >= 9 && n2 <= 17)
//{
//    var flightFare = (n1 * 20 / 100) + n1;
//    Console.WriteLine("Flight Fare:"+flightFare);
//}
//else if (n2 >= 17 && n2 <= 23)
//{
//    var flightFare = (n1 * 7 / 100) + n1;
//    Console.WriteLine("Flight Fare:" +   flightFare);
//}
//else 
//{
//    var flightFare = (n1 * 5 / 100) + n1;
//    Console.WriteLine("Flight Fare:" +   flightFare);
//}
//Console.WriteLine("Enter 10 flight fares(in decimal format):");
//double[] arr = new double[3];
//for (int i = 0; i < 3; i++)
//{
//    arr[i] = double.Parse(Console.ReadLine());
//}
//Console.WriteLine("-------");
//Console.WriteLine("sorting");
//Console.WriteLine("-------");
//Array.Sort(arr);
//foreach (double s in arr)
//{
//    Console.WriteLine(s);
//}

//Console.WriteLine("-------");
//Console.WriteLine("reverse sorting");
//Console.WriteLine("-------");
//Array.Reverse(arr);
//foreach (double s in arr)
//{
//    Console.WriteLine(s);
//}
//Console.WriteLine("-------");
//Console.WriteLine("searching");
//Console.WriteLine("-------");
//Console.WriteLine("Enter a value to search:");
//double value = double.Parse(Console.ReadLine());
//bool searchedName = arr.Contains(value);
//Console.WriteLine(searchedName);
//int flag = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; i < arr.Length; i++)
//    {
//        if (value == arr[i])
//        {

//            flag = 1;
//        }

//    }

//}
//if (flag != 0)
//{
//    Console.WriteLine("value:" + value);
//}
//else
//{
//    Console.WriteLine("no such name");
//}

//Console.WriteLine("-------");
//Console.WriteLine("duplicate");
//Console.WriteLine("-------");
//var count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            count++;
//            Console.Write(arr[i]);
//        }
//    }
//}
//if (count == 0)
//    Console.WriteLine("no dupliacte values");

//Console.WriteLine("-------");
//Console.WriteLine("max and min values");
//Console.WriteLine("-------");
//var MinValue = arr[0];
//var MaxValue = arr[0];
//for (int i = 0;i < arr.Length; i++)
//{
//    if(MinValue > arr[i])
//    {
//        MinValue = arr[i];
//    }
//    if (MaxValue < arr[i]) 
//    {
//        MaxValue = arr[i];
//    }
//}
//Console.WriteLine("min value:"+MinValue);
//Console.WriteLine("max value:"+MaxValue);


//Console.WriteLine("-------");
//Console.WriteLine("Dob of passengers");
//Console.WriteLine("-------");

//Console.WriteLine("Enter Dob:");
//DateTime[] arr = new DateTime[3];
//for (int i = 0; i < 3; i++)
//{
//    arr[i] = Convert.ToDateTime(Console.ReadLine());
//}
//foreach (DateTime dt in arr)
//{
//    Console.WriteLine(dt.ToString());
//}
//foreach (DateTime dt in arr)
//for(int i = 0; i < 3; i++)
//{
//    DateTime[] varsha = arr[i].Split('');
//    Console.WriteLine(varsha[i]);
//}

//string[] arr2 = new string[5];
//for (int i = 0;i < arr.Length; i++)
//{
//    for(int j = i+1; i <arr.Length; j++)
//    {
//        string[] 
//    }
//}



//Console.WriteLine("-------");
//Console.WriteLine("Dob of passengers");
//Console.WriteLine("-------");

//Console.WriteLine("Enter Dob:");
//DateTime dob = DateTime.Parse(Console.ReadLine());
//var age = DateTime.Now.Year - dob.Year;
//var AgeInHours = age * 8760;
//Console.WriteLine("AGE IN HOURS:"+AgeInHours);
//var AgeInDays = age * 365;
//Console.WriteLine("AGE IN DAYS: " +AgeInDays);
//var AgeInWeeks = age * 52.1429;
//Console.WriteLine("AGE IN WEEKS: " + AgeInWeeks);
//var AgeInMonths = age * 12;
//Console.WriteLine("AGE IN MONTHS: " + AgeInMonths);
//Console.WriteLine("AGE IN YEARS: " + age);
//if(dob.Year % 4 == 0)
//{
//    var LeapYearOrNot = dob.Year;
//    Console.WriteLine("This Year Is A Leap Year" +LeapYearOrNot);
//}
//else
//{
//    Console.WriteLine("not a leap year");
//}


Console.WriteLine("-------");
Console.WriteLine("Even Or Odd");
Console.WriteLine("-------");
Console.WriteLine("Enter the array limit:");

decimal[] arr = new decimal
Console.WriteLine("Enter flight fares(decimal format):");
for (int i = 0;i < 5; i++)
