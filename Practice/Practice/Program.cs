using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str,int age);

        //public delegate int StringLength(string str); 
        static void Main(string[] args)
        {

            #region Predicate
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(Sum(CheckGreaterThanFour,arr));

            //List<int> list = new List<int> { 1, 2, 3, 5, 6 };
            //var result = SumOfNUmbersDividedBy3And7(CheckNumbersDividedBy3And7, list);
            //Console.WriteLine(result);

            //var result = list.FindAll(m => m % 3 == 0 && m % 7 == 0).Sum(m => m);
            //var result = nums.FindAll(CheckGreaterThanFour);
            //var result=nums.FindAll(m=>m%2==0 && m>5)

            //Console.WriteLine(result.Count);
            #endregion


            //string name = "Gultaj";
            //ShowString(StringToLower, name);

            //ChangeString func = StringToLower;
            //func += StringToUpper;
            //func += delegate (string str, int age)
            //  {
            //      Console.WriteLine(str.ToUpper());
            //  };
            //func += (str, age) => Console.WriteLine(str.ToUpper());

            //func.Invoke("Gultac",18);


            //    Action<string, int> action = StringToUpper;
            //    action.Invoke("Gultaj", 18);

            //    Action action1 = Test;
            //    action1.Invoke();

            //    PowerOfNumber(CalculatePOwer, 3, 4);
            //    Action<int, int> action = CalculatePOwer;
            //    action.Invoke(3, 4);
            //    }


            //    public static void CalculatePOwer(int num,int pow)
            //    {
            //           Console.WriteLine(Math.Pow(num,pow));
            //    }
            //    public static void PowerOfNumber(Action<int,int> func,int num,int pow)
            //{
            //    func(num, pow);


            //ShowStringLength(GetStringLength, "Gultac");

            //Func<string, int> func = GetStringLength;
            //Console.WriteLine(func.Invoke("Gultaj"));

            ShowFactorial(Factorial,5);

        }

        public static int Factorial(int num)
        {
            int res = 1;
            while (num != 1)
            {
                res = res * num;
                num--;
            }
            return res;
        }


        public static void ShowFactorial(Func<int,int> function,int num )
        {
            Console.WriteLine(function(num));
        }
        //public static void Test()
        //{
        //    Console.WriteLine("test");
        //}

        //public static int GetStringLength(string str)
        //{
        //    return str.Length;
        //}


        //public static void ShowStringLength(Func<string,int> func,string word)
        //{
        //    Console.WriteLine(func(word));
        //}


        //public static void StringToLower(string str,int age)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //public static void StringToUpper(string str,int age)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}


        //public static void ShowString(Action<string,int>action, string str, int age)
        //{
        //    action(str, age);
        //}





        //public static bool CheckNumbersDividedBy3And7(int num)
        //{
        //    return num % 3 == 0 && num % 7 == 0;
        //}
        //public static int SumOfNUmbersDividedBy3And7(Predicate<int> predicate,List<int> list)
        //{
        //    int sum = 0;
        //    foreach (var item in list)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }

        //   }
        //    return sum;
        //}


        //public static bool CheckGreaterThanFour(int number)
        //{
        //    return number > 4;
        //}
        //public static bool CheckOddNUms(int number)
        //{
        //    return number % 2 != 0;
        //}
        //public static bool CheckEvenNUms(int number)
        //{
        //    return number % 2 == 0;
        //}


        //public static int Sum(Predicate<int> predicate , int [] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        //public static int SumEvenNums(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
    }


    }

  

    

