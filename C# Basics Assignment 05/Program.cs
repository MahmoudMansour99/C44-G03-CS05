namespace C__Basics_Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Looping | Iteration Statements

            #region For - Foreach

            //int[] Numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);
            //Console.WriteLine($"Number is {Numbers[0]}");
            //Console.WriteLine($"Number is {Numbers[1]}");
            //Console.WriteLine($"Number is {Numbers[2]}");
            //Console.WriteLine($"Number is {Numbers[3]}");
            //Console.WriteLine($"Number is {Numbers[4]}");
            //Console.WriteLine($"Number 0 is {Numbers[0]}");
            //Console.WriteLine($"Number 1 is {Numbers[1]}");
            //Console.WriteLine($"Number 2 is {Numbers[2]}");
            //Console.WriteLine($"Number 3 is {Numbers[3]}");
            //Console.WriteLine($"Number 4 is {Numbers[4]}");

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    //Numbers[i] += 10;
            //    if (i == 2)
            //        break;
            //        //continue;
            //    Console.WriteLine($"Number {i} is {Numbers[i]}");
            //}

            //foreach (int item in Numbers)
            //{
            //    //item += 10;
            //    Console.WriteLine(item);
            //}

            #endregion

            #region While | Do-While

            #region do-while

            //int Number;
            //bool IsParse;

            //do
            //{
            //Console.WriteLine("Enter Even Number");
            //IsParse = int.TryParse(Console.ReadLine(), out Number);
            //}
            //while (Number % 2 != 0 || !IsParse);

            //Console.WriteLine($"{Number} is an Even Number");

            #endregion

            #region While

            //Console.Write("Enter a Number: ");
            //bool IsParse = int.TryParse(Console.ReadLine(), out int Number);

            //if (IsParse)
            //{
            //    while (Number <= 10)
            //    {
            //        Console.WriteLine(Number);
            //        Number++;
            //    }
            //}

            #endregion

            #endregion

            #endregion

            #region String

            #region Example 01

            //string Name;

            //Name = new string("Route"); // 10 bytes

            //Console.WriteLine($"Name 01 is {Name}");
            //Console.WriteLine($"Hash Code is {Name.GetHashCode()}");

            //string Name02 = "Route";

            //Console.WriteLine($"Name 02 is {Name02}");
            //Console.WriteLine($"Hash Code is {Name02.GetHashCode()}");

            #endregion

            #region Example 02

            //string Name01 = "Amr";
            //string Name02 = "May";

            //Console.WriteLine($"Name 01 is {Name01}");
            //Console.WriteLine($"Hash Code is {Name01.GetHashCode()}");

            //Console.WriteLine($"Name 02 is {Name02}");
            //Console.WriteLine($"Hash Code is {Name02.GetHashCode()}");

            //Name02 = Name01;

            //Console.WriteLine($"Name 01 is {Name01}");
            //Console.WriteLine($"Hash Code is {Name01.GetHashCode()}");

            //Console.WriteLine($"Name 02 is {Name02}");
            //Console.WriteLine($"Hash Code is {Name02.GetHashCode()}");

            #endregion

            #region Example 03

            //string Message = "Hello";

            //Console.WriteLine($"Message = {Message}");
            //Console.WriteLine($"Message HashCode = {Message.GetHashCode()}");

            //Message += " Route";

            //Console.WriteLine("After Amend");
            //Console.WriteLine($"Message = {Message}");
            //Console.WriteLine($"Message HashCode = {Message.GetHashCode()}");

            #endregion

            #endregion

            #region String Methods

            //string Message = "   Hello Route   ";

            //Console.WriteLine(Message.Length);
            //Console.WriteLine(Message.ToLower());
            //Console.WriteLine(Message.ToUpper());
            //Console.WriteLine(Message.Trim());
            //Console.WriteLine(Message.TrimEnd());
            //Console.WriteLine(Message.TrimStart());
            //Console.WriteLine(Message.Substring(0, 5));
            //Console.WriteLine(Message.Replace('e', 't'));
            //Console.WriteLine(Message.Contains('o'));
            //Console.WriteLine(Message.GetType());

            #endregion
        }
    }
}
