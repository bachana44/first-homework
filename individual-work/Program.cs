







using System.Diagnostics;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("student name: ");
            //string studentName = Console.ReadLine();
            //Console.WriteLine("your grade: ");
            //int studentGrade = Convert.ToInt32(Console.ReadLine());

            //switch (studentGrade)
            //{
            //    case int grade when grade >= 90 && grade <= 100:
            //        Console.WriteLine($"{studentName} your grade is A+");
            //        break;
            //    case int grade when grade >= 80 && grade < 90:
            //        Console.WriteLine($"{studentName} your grade is A");
            //        break;
            //    case int grade when grade >= 70 && grade < 80:
            //        Console.WriteLine($"{studentName} your grade is B");
            //        break;
            //    case int grade when grade < 70:
            //        Console.WriteLine($"{studentName} your grade is C or below");
            //        break;
            //    default:
            //        Console.WriteLine("your number doest exist");
            //        break;
            //}




            //int[] numbers = [10, 20, 340, 30, 40, 9];
            //int luwi = 0;
            //int kenti = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        luwi++;
            //    }
            //    else
            //    {
            //        kenti++;
            //    }
            //}
            //Console.WriteLine($"luci ricxvebis raodenoba {luwi}");
            //Console.WriteLine($"kenti ricxvebis raodenoba {kenti}");



            int[] numbers = [10, 20, 340, 30, 40, 9];
            int firstNumberPosition = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == firstNumberPosition)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}

