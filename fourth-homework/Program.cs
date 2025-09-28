using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fourth_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Print Array Elements

            //int[] numbers = [ 1, 2, 3, 4, 5 ];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //2.Find Maximum Element

            //int[] numbers = [1, 2, 3, 4, 5];
            //int maxNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);



            //3.Find Minimum Element
            //int[] numbers = [1, 2, 3, 4, 5];
            //int minNumber = numbers[0];

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    if (number[i] < minNumbers)
            //    {
            //        minNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(minNumber);



            //4.Sum of Array Elements
            //int[] numbers = [1, 2, 3, 4, 5];
            //int sum = 0;


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //5. Reverse Array

            //int[] numbers = [1, 2, 3, 4, 5];

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    int reversedNumbers = numbers[i];
            //    Console.WriteLine(reversedNumbers);
            //}


            //6.Count Even and Odd Numbers
            //int[] numbers = [1, 2, 3, 4, 5];
            //int evenNumbers = 0;
            //int oddNumbers = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenNumbers++;
            //    }
            //    else
            //    {
            //        oddNumbers++;
            //    }
            //}
            //Console.WriteLine($"Even numbers = {evenNumbers}");
            //Console.WriteLine($"Odd numbers = {oddNumbers}");



            //7. Search Element in Array


            //Console.Write("Choose your number: ");
            //int choosenNumber = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = [1, 2, 3, 4, 5];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == choosenNumber)
            //    {
            //        Console.WriteLine("we have your number in array");
            //    }
            //    else
            //    {
            //        Console.WriteLine("we dont have your number in array");
            //    } 
            //}



            //8.Copy Array

            //int[] numbers = [1, 2, 3, 4, 5, 2,];
            //int newNumbersArray = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    newNumbersArray = numbers[i];
            //    Console.WriteLine(newNumbersArray);
            //}


            //9.Second Largest Number

            //int[] numbers = [1, 2, 3, 4, 5, 2, 7];
            //int maxNumber = numbers[0];
            //int secLargestNumber = numbers[0];

            //foreach (var num in numbers)
            //{
            //    if (num > maxNumber)
            //    {
            //        secLargestNumber = maxNumber;
            //        maxNumber = num;
            //    }
            //}

            //Console.WriteLine(secLargestNumber);

            //10.Frequency of Elements

            //int[] numbers = [1, 2, 3, 4, 5, 2, 7, 1];
            //int counter = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine($"{numbers[i]} ganmeorda {counter}-jer");
            //    counter = 0;
            //}




            //1.Array Rotation

            //int[] numbers = [1, 2, 3, 4, 5, 2, 7, 1];

            //Console.Write("Choose direction: ");
            //string direction = Console.ReadLine();



            //if (direction == "left")
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //else if (direction == "right") 
            //{
            //    for (int i = numbers.Length - (1); i >= 0; i--)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //} 






            //2.Sort Array Without Built -in Sort   (ეს დავალება ვერგავაკეთე)


            //3.Remove Duplicates 










            //4.Merge Two Arrays

            //Console.Write("Which array u want, 'first', 'second' 'merged': ");
            //string txt = Console.ReadLine();  

            //int[] firstArray = [1, 2, 3, 4, 5, 2, 7, 1];
            //int[] secondArray = [3, 8, 2, 1,];


            //if (txt == "first")
            //{
            //    for (int i = 0; i < firstArray.Length; i++)
            //    {
            //        Console.WriteLine(firstArray[i]);
            //    }
            //}else if (txt == "second")
            //{
            //    for (int i = 0; i < secondArray.Length; i++)
            //    {
            //        Console.WriteLine(secondArray[i]);
            //    }
            //}   
            //else if (txt == "merged")
            //{
            //    for (int i = 0; i < firstArray.Length; i++)
            //    {
            //        Console.WriteLine(firstArray[i]);
            //    }
            //    for (int j = 0; j < secondArray.Length; j++)
            //    {
            //        Console.WriteLine(secondArray[j]);
            //    }

            //} 


            //5.Insert Element in Array     (აქ chatgpt დავიხმარე  newArray[newArray.Length - 1] = insertedNumber; - ცოტა გაუგებარია მაგრამ სხვა დანარცჩენი გასაგები 

            //Console.Write("Write number u want to insert in array: ");
            //int insertedNumber = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = [1, 2, 3, 4, 5, 2, 7, 1];
            //int[] newArray = new int[numbers.Length + 1];



            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    newArray[i] = numbers[i];
            //}

            //newArray[newArray.Length - 1] = insertedNumber;
            //numbers = newArray;

            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i]);
            //}


           

        }
    }
}
