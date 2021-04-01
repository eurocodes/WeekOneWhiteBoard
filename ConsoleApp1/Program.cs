using System;
using System.Collections.Generic;

namespace WhiteBoardingWeekOne
{
    class Program
    {
        public static string FindTheMostRepeated(string word)
        {
            int i, j;
            string[] arrStr = new string[word.Length];
            int[] arrNum = new int[word.Length];
            for (i = 0; i < word.Length; i++)
            {
                int count = 1;
                for (j = i + 1; j < word.Length; j++)
                {
                    
                    if (word[i] == word[j])
                    {
                        count++;
                        arrStr[i] = word[i].ToString();
                        arrNum[i] = count;
                    }
                }
            }
            int bigNum = arrNum[0];
            for (i = 0; i < arrNum.Length; i++)
            {
                if (arrNum[i] > bigNum)
                {
                    bigNum = arrNum[i];
                }
            }
            for (i = 0; i < arrNum.Length; i++)
            {
                if (arrNum[i] == bigNum)
                {
                    return arrStr[i];
                }
            }
            return "none";
        }

        public static int NumChips(int amount)
        {
            int numChip = 0;
            int[] luigyArr = { 100, 50, 25, 10, 5, 1 };
            do
            {
                for (int i = 0; i < luigyArr.Length; i++)
                {
                    if (amount < luigyArr[i])
                    {
                        continue;
                    }
                    else
                    {
                        amount -= luigyArr[i];
                        numChip++;

                    }
                }
            } while (amount != 0);
            return numChip;
        }

        public static int[] ProductInt(int[] arr)
        {
            int i, j;
            int[] newArr = new int[arr.Length];
            for (i = 0; i < arr.Length; i++)
            {
                int multiple = 1;
                for(j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        multiple *= arr[j];
                    }
                }
                newArr[i] = multiple;
                multiple = 1;

            }
            return newArr;
        }

        public static int PokerChips(int number)
        {
            int counter = 0;
            var myArr = new int[] { 100, 50, 25, 10, 5, 1 };
            var myList = new List<int>();
            for (int i = 0; i < myArr.Length; i++)
            {
                if (number >= myArr[i])
                {
                    number %= myArr[i];
                    counter += 1;
                    myList.Add(myArr[i]);
                }
                else
                    continue;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 1, 5 };
            Console.WriteLine("Longest repeated "+ FindTheMostRepeated("Hello world"));
            Console.WriteLine("Num Chips "+NumChips(155));
            Console.WriteLine("Num Chips Tech Art " + PokerChips(153));
            int[] myArr = ProductInt(arr);

            foreach (int item in myArr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
