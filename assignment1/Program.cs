using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(JudgeCircle("LL"));
            Console.WriteLine(CheckIfPangram("thequickbrownfoxjumpsoverthelazydog"));
            //
            int[] arr = { 1, 1, 1, 1 };
            NumIdenticalPairs(arr);
            int[] arr2 = { 1,7,3,6,5,6 };
            Console.WriteLine(PivotIndex(arr2));
            Console.WriteLine(MergeAlternately("abcd", "pq"));
            Console.WriteLine(ToGoatLatin("goat latin"));
        }

        static bool JudgeCircle(string moves)
        {
            int hcount = 0;
            int ycount = 0;
            for (int i = 0; i < moves.Length; i+=1)
            {
                if (Convert.ToString(moves[i]) == "L")
                {
                    hcount += 1;
                }
                else if(Convert.ToString(moves[i]) == "R")
                {
                    hcount -= 1;
                }
                else if (Convert.ToString(moves[i]) == "U")
                {
                    ycount -= 1;
                }
                else if (Convert.ToString(moves[i]) == "D")
                {
                    ycount += 1;
                }
            }
            if(hcount==0 & ycount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static bool CheckIfPangram(string str)
        {
            string alpha = "leetcode";
            Console.WriteLine(alpha.Length);
            int count = 0;
            foreach(char i in alpha)
            {
                if (str.Contains(i))
                {
                    count += 1;
                }
            }
            if (count == 26)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static int NumIdenticalPairs(int[] arr)
        {
            int count = 0;
            for(int i=0; i < arr.Length; i++)
            {
                for (int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count += 1;
                    }
                }
            }
            Console.WriteLine(count);
            return count;
        }
        static int PivotIndex(int[] nums)
        {
            if (nums.Length == 0) return -1;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum - nums[i];
                if (leftSum == sum)
                    return i;
                else
                    leftSum += nums[i];

            }
            return -1;
        }
        static string MergeAlternately(string word1, string word2)
        {
            int i = 0;
            int j = 0;
            string temp = "";
            bool bool1 = true;
            bool bool2 = false;
            while (i < word1.Length & j < word2.Length)
            {
                if (bool1)
                {
                    temp += word1[i];
                    i += 1;
                    bool2 = true;
                    bool1 = false;
                }
                if (bool2)
                {
                    temp += word2[j];
                    j += 1;
                    bool1 = true;
                    bool2 = false;
                }
            }
            if (i != word1.Length)
            {
                temp += word1.Substring(i);
            }
            if (j != word2.Length)
            {
                temp += word2.Substring(j);
            }
            return temp;
        }
        static string ToGoatLatin(string sentence)
        {
            string example = "aeiouAEIOU";
            string[] splitStr = sentence.Split(' ');
            string res = "";
            for (int i = 0; i < splitStr.Length; i++)
            {
                string newStr = splitStr[i];

                res += example.Contains(newStr[0]) ? (newStr + "ma") : newStr.Substring(1) + newStr[0] + "ma";

                res += new String('a', i + 1);
                if (i != splitStr.Length - 1) res += " ";
            }

            return res;
        }
    }
}
