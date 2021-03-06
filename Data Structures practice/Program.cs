﻿using System;

namespace Data_Structures_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] RandNumArr = new int[10];
            List list = new List();

            for(int i = 0; i <= 9; i++)
            {
                Random random = new Random();
                int rand = random.Next(10);
                RandNumArr[i] = rand;
                Console.WriteLine(RandNumArr[i]);
            }

            foreach(var num in RandNumArr)
            {
                Node node = new Node(num);
                list.Insert(node);
            }

            while (true)
            {
                string UserInput;
                Console.WriteLine("What program would you like to run?");
                Console.WriteLine("1: Linked List demo" + 
                    "\n2: Binary Search" +
                    "\n3: Palindrome Check");
                UserInput = Console.ReadLine();
                if(UserInput == "1")
                {
                    ListProg();
                }
                if(UserInput == "2")
                {
                    BinarySeach(RandNumArr);
                }
                if(UserInput == "3")
                {
                    PalindromeDemo();
                }
            }

            void BinarySeach(int[] arr)
            {
                Console.WriteLine("What Number would you like to search for?");
                int SearchNum = Convert.ToInt32(Console.ReadLine());
            }

            void PalindromeDemo()
            {
                Console.WriteLine("Please Input a string to check.");
                string input = Console.ReadLine().ToLower();
                Palindrome palindrome = new Palindrome();
                bool check = palindrome.checkPalindrome(input);
                Console.WriteLine("Checking the complex way.");
                Console.WriteLine($"Is string \"{input}\" a Palindrome? : {check}");
                Console.WriteLine("Checking the lazy way");
                bool lazyCheck = palindrome.LazyPalindromeCheck(input);
                Console.WriteLine($"Is string \"{input}\" a Palindrome? : {lazyCheck}");
                
            }

             void ListProg()
            {
                list.PrintList();
                Console.WriteLine("Please input a number to Search the list for.");
                string input = Console.ReadLine();
                int find = Convert.ToInt32(input);
                Node searchNode = new Node(find);
                var result = list.Search(searchNode);

                if (result != null)
                {
                    Console.WriteLine($"Node: {result._value} successfully found!");
                    Console.WriteLine($"Would you like to delet this Node? y:n?");
                    string newinput = Console.ReadLine();
                    if (newinput.Equals("y"))
                    {
                        list.DeleteNode(result);
                        list.PrintList();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Node: {result} Could not be located.");
                }
            }
        }
    }
}
