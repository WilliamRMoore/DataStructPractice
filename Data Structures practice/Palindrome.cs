using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_practice
{
    class Palindrome
    {
        public bool LazyPalindromeCheck(string str)
        {
            char[] strArr = str.ToCharArray();
            Array.Reverse(strArr);
            string reversed = new string(strArr);

            if (str.Equals(reversed))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkPalindrome(string str)
        {
            int LeftPointer = 0;
            int RightPointer = str.Length - 1;

            while(LeftPointer < RightPointer)
            {
                if(str[LeftPointer] == str[RightPointer])
                {
                    LeftPointer++;
                    RightPointer--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
