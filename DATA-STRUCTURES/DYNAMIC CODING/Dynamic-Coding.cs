

using System;
using System.Collections.Generic;
using System.Linq;

namespace DATA_STRUCTURES.DYNAMIC_CODING
{
    public class Dynamic_Coding  
    {
        //  Given a string, compute recursively the number of times lowercase "hi" appears in the string, however do not count "hi" that have an 'x' immedately before them.
        //  countHi2("ahixhi") → 1
        //  countHi2("ahibhi") → 2
        //  countHi2("xhixhi") → 0
        public int countHi2(string str)
        {
            string threeCharSub = str.Substring(0, 3);

            if (str.Length < 2 || string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            if (threeCharSub.StartsWith("hi"))
            {
                return 1 + countHi2(str.Substring(2));
            }

            if (threeCharSub.StartsWith("x"))
            {
                return countHi2(str.Substring(2));
            }

            if (!threeCharSub.StartsWith("x"))
            {
                if (threeCharSub.Contains("hi"))
                {
                    return 1 + countHi2(str.Substring(3));
                }
                else
                {
                    return countHi2(str.Substring(2));
                }
            }
            return countHi2(str.Substring(1));
        }

        public int strCount(String str, String sub)
        {
            if (str == sub)
            {
                return 1;
            }

            if (str.Length < sub.Length)
            {
                return 0;
            }

            if (str.StartsWith(sub))
            {
                return 1 + strCount(str.Substring(sub.Length), sub);
            }

            return strCount(str.Substring(1), sub);
        }

        //  We have triangle made of blocks.The topmost row has 1 block, the next row down has 2 blocks, the next row has 3 blocks, and so on.Compute
        //  recursively (no loops or multiplication)the total number of blocks in such a triangle with the given number of rows.triangle(0) → 0
        //  triangle(1) → 1
        //  triangle(2) → 3
        public int triangle(int rows)
        {
            if (rows == 0)
            {
                return 0;
            }

            if (rows == 1)
            {
                return 1;
            }
            return rows + triangle(rows - 1);
        }

        //  Given a non-negative int n, compute recursively(no loops) the count of the occurrences of 8 as a digit, except that an 8 with another 8
        //  immediately to its left counts double, so 8818 yields 4. Note that mod(%) by 10 yields the rightmost digit(126 % 10 is 6),
        //  while divide(/) by 10 removes the rightmost digit(126 / 10 is 12).
        //  count8(8) → 1
        //  count8(818) → 2
        //  count8(8818) → 4

        public int count8(int n)
        {

            if (n % 10 == 8)
            {
                if (((n / 10) % 10) == 8)
                {
                    return 2 + count8(n / 10);
                }
                return 1 + count8(n / 10);
            }

            if (n % 10 == 0)
            {
                return 0;
            }

            return count8(n / 10);

        }


        //  Given a string, compute recursively(no loops) the number of times lowercase "hi" appears in the string.
        //  countHi("xxhixx") → 1
        //  countHi("xhixhix") → 2
        //  countHi("hi") → 1
        public int countHi(String str)
        {

            if (str.Length < 2)
            {
                return 0;
            }

            if (str.StartsWith("hi"))
            {
                return 1 + countHi(str.Substring(2));
            }

            return countHi(str.Substring(1));

        }


        //  Given a string, compute recursively a new string where all the 'x' chars have been removed.
        //  noX("xaxb") → "ab"
        //  noX("abc") → "abc"
        //  noX("xx") → ""
        public String noX(String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            if (str[0] != 'x')
            {
                return str[0] + noX(str.Substring(1));
            }

            if (str.Length == 1)
            {
                return "";
            }

            return noX(str.Substring(1));
        }


        //  Given an array of ints, compute recursively if the array contains somewhere a value followed in the array by that value times 10.
        //  We'll use the convention of considering only the part of the array that begins at the given index. In this way, a recursive call 
        //  can pass index+1 to move down the array. The initial call will pass in index as 0.
        //  array220([1, 2, 20], 0) → true
        //  array220([3, 30], 0) → true
        //  array220([3], 0) → false
        public bool array220(int[] nums, int index)
        {

            if (nums.Length < 2 || nums.Length - 1 == index)
            {
                return false;
            }

            if (nums[index] == nums[index + 1] / 10)
            {
                return true;
            }
            return array220(nums, ++index);

        }


        //  Given a string, compute recursively(no loops) the number of "11" substrings in the string.
        //  The "11" substrings should not overlap.
        //  count11("11abc11") → 2
        //  count11("abc11x11x11") → 3
        //  count11("111") → 1
        public int count11(String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            if (str.StartsWith("11"))
            {
                return 1 + count11(str.Substring(2));
            }
            return count11(str.Substring(1));
        }


        //  Given a string that contains a single pair of parenthesis, compute recursively a new string made of
        //  only of the parenthesis and their contents, so "xyz(abc)123" yields "(abc)".
        //  parenBit("xyz(abc)123") → "(abc)"
        //  parenBit("x(hello)") → "(hello)"
        //  parenBit("(xy)1") → "(xy)"
        public String parenBit(String str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            if (!str.Contains("(") && !str.Contains(")"))
            {
                return "";
            }

            if (str[0] == '(')
            {
                return '(' + parenBit(str.Substring(1));
            }

            if (str.Contains(")") && !str.Contains("("))
            {
                return str[0] + parenBit(str.Substring(1));
            }

            if (str[0] == ')')
            {
                return ')' + parenBit("");
            }
            return parenBit(str.Substring(1));

        }

        //  Given a string, compute recursively(no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.
        //  changeXY("codex") → "codey"
        //  changeXY("xxhixx") → "yyhiyy"
        //  changeXY("xhixhix") → "yhiyhiy"
        public String changeXY(String str)
        {

            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            if (str == "x")
            {
                return "y";
            }


            if (str[0] == 'x')
            {
                return 'y' + changeXY(str.Substring(1));
            }

            return str[0] + changeXY(str.Substring(1));

        }

        //  Given a string, compute recursively a new string where all the adjacent chars are now separated by a "*".
        //  allStar("hello") → "h*e*l*l*o"
        //  allStar("abc") → "a*b*c"
        //  allStar("ab") → "a*b"
        public string allStar(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            if (str.Length == 1)
            {
                return str;
            }

            return str[0] + '*' + allStar(str.Substring(1));
        }

        // Mutiply two numbers recursively A and B
        // Step 1, Define the method i,e   int GetMultiply(int A, int B)
        // Step 2, Think of the question as a series of answers starting from input B=0 to input B=B.
        // Step 3, Take a small  example of A being a value like 2, and 2
        // Step 4, Manually Work out the GetMultiply of 2, 1,  and GetMultiply 2, 2, this will give you a series of (b=1)2,  (b=2)4
        // Step 5  Ask yourself how you can get value of b=2 from value of b = 1;
        static int MultiplyTwoNums(int A, int B)
        {
            if (B < 1)
            {
                return A;
            }

            return A + MultiplyTwoNums(A, --B);
        }

        static Dictionary<int, int> inputs = new Dictionary<int, int>();


        /// Given a number num, get the index of the number in a fibanaci series
        static int FibonnaciOf(int N)
        {
            if (N < 2)
            {
                return 1;
            }

            return FibonnaciOf(N - 1) + FibonnaciOf(N - 2);
        }


        // QUESTION: Get Factorial of a Given Integer N
        // Step 1. Express the problem as a method defination like so  GetFactorial(int N)
        // Step 2. Think of the solution as a series of answers starting from the parameter = 0 up to the point the parameter = A;
        // Step 3. Take a small  example of A being a value like 4
        // Step 4. Manually Work out the Factorial of 4, i.e   4th =  24
        // Step 5. Then manually work out the factorial   i.e  3rd  =  6
        // Step 6. Now that you know the two values worked out, i.e 24 and 6
        //      Ask yourself how can you get the 4th Value, by operating on the 3rd Value. You can quickly see that 4th value = 3rd Value X position 4
        //      We can express this as  =   FactorialOf(3) * 4
        //      We can generalise then as Factorial of N = FactorialOf(N-1) * N; 
        static private int GetFactorial(int A)
        {
            if (A == 1)
            {
                return 1;
            }
            return A * GetFactorial(A - 1);
        }


        // Reverse a string recursively
        // A String is an arrar of chacracters
        // Treat this problem as a series
        // The last item = first character + reverse of the rest
        static string GetRevers(string myString)
        {
            if (myString.Length <= 1)
            {
                return myString;
            }
            char firstLetter = myString[0];

            string rest = myString.Substring(1);

            return GetRevers(rest) + firstLetter;
        }


        // Get sum of natuaral numbers from 0 to N
        static int RecursiveSum(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N + RecursiveSum(--N);
        }

        // Print individual digits of number
        static void PrintNum(int N)
        {
            if (N < 10)
            {
                Console.Write(N);
                return;
            }
            PrintNum(N / 10);

            Console.Write(N % 10);
        }

        //Write a program to check whether a number is prime or not using recursion.
        static bool IsPrime(int N, int index = 2)
        {
            if (index == N)
            {
                return true;
            }
            if (N % index == 0)
            {
                return false;
            }
            return IsPrime(N, ++index);
        }

        //  Write a recursive  program in to print all odd numbers in a given array
        static void printOdd(int[] arr)
        {
            while (arr.Length >= 0)
            {
                if (arr[0] % 2 != 0)
                {
                    Console.WriteLine(arr[0]);
                }
                if (arr.Length > 0)
                {
                    printOdd(arr.Skip(1).ToArray());
                }
                else
                {
                    return;
                }
            }
        }


        //  Given a non-negative int n, return the count of the occurrences of 7 as a digit, so for example 717 yields 2.
        //  (no loops). Note that mod(%) by 10 yields the rightmost digit(126 % 10 is 6), while divide(/) by 10 removes the 
        //  rightmost digit(126 / 10 is 12).
        //  count7(717) → 2
        //  count7(7) → 1
        //  count7(123) → 0
        public int count7(int n)
        {
            if (n < 1)
            {
                return 0;
            }

            if (n == 7)
            {
                return 1;
            }

            if (n % 10 == 7)
            {
                return 1+ count7(n / 10);
            }

            return count7(n / 10);
        }

        //Given a string, compute recursively (no loops) the number of lowercase 'x' chars in the string.
        public int countX(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            if (str.StartsWith("x"))
            {
                return 1 + countX(str.Substring(1));
            }

            if (str.Length == 1)
            {
                return 0;
            }
            return countX(str.Substring(1));
        }


        //  Given a string, compute recursively(no loops) a new string where all appearances of "pi" have been replaced by "3.14".
        //  changePi("xpix") → "x3.14x"
        //  changePi("pipi") → "3.143.14"
        //  changePi("pip") → "3.14p"
        public string changePi(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }

            if (str.Length == 1)
            {
                return str[0].ToString();
            }

            if (str.StartsWith("pi"))
            {
                return "3.14" + changePi(str.Substring(2));
            }
            return str[0] + changePi(str.Substring(1));
        }


        //  Given an array of ints, compute recursively the number of times that the value 11 appears in the array.
        //  We'll use the convention of considering only the part of the array that begins at the given index. 
        //  In this way, a recursive call can pass index+1 to move down the array. The initial call will pass in index as 0.
        //  array11([1, 2, 11], 0) → 1
        //  array11([11, 11], 0) → 2
        //  array11([1, 2, 3, 4], 0) → 0
        public int array11(int[] nums, int index)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (index == nums.Length - 1)
            {
                if (nums[index] == 11)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            if (nums[index] == 11)
            {
                return 1 + array11(nums, ++index);
            }

            return array11(nums, ++index);
        }


        //  Given a string, compute recursively a new string where identical chars that are adjacent in 
        //  the original string are separated from each other by a "*".
        //  pairStar("hello") → "hel*lo"
        //  pairStar("xxyy") → "x*xy*y"
        //  pairStar("aaaa") → "a*a*a*a"
        public string pairStar(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            if (str.Length < 2)
            {
                return str;
            }

            if (str[0] == str[1])
            {
                return str[0] + "*" + pairStar(str.Substring(1));
            }

            return str[0] + pairStar(str.Substring(1));
        }


        //  Count recursively the total number of "abc" and "aba" substrings that appear in the given string.
        public int countAbc(String str)
        {
            if (str.StartsWith("abc") || str.StartsWith("aba"))
            {
                return 1 + countAbc(str.Substring(2));
            }

            if (str.Length < 3)
            {
                return 0;
            }

            return countAbc(str.Substring(1));
        }
    }
}
