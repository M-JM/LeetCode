using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

//Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000
//For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

//Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:

//I can be placed before V (5) and X(10) to make 4 and 9. 
//X can be placed before L(50) and C(100) to make 40 and 90. 
//C can be placed before D(500) and M(1000) to make 400 and 900.
//Given a roman numeral, convert it to an integer.


    public static class RomanToInteger
    {
        public static int RomanToIntMyVersion(string s)
        {
            List<int> list = new List<int>();

            string a = s.Replace("IV", "1").Replace("IX", "2").Replace("XL", "3").Replace("XC", "4").Replace("CD", "5").Replace("CM", "6");

            Console.WriteLine(a);

            char[] characters = a.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                switch (characters[i])
                {
                    case '1':
                        list.Add(4);
                        break;
                    case '2':
                        list.Add(9);
                        break;
                    case '3':
                        list.Add(40);
                        break;
                    case '4':
                        list.Add(90);
                        break;
                    case '5':
                        list.Add(400);
                        break;
                    case '6':
                        list.Add(900);
                        break;
                    case 'I':
                        list.Add(1);
                        break;
                    case 'V':
                        list.Add(5);
                        break;
                    case 'X':
                        list.Add(10);
                        break;
                    case 'L':
                        list.Add(50);
                        break;
                    case 'C':
                        list.Add(100);
                        break;
                    case 'D':
                        list.Add(500);
                        break;
                    case 'M':
                        list.Add(1000);
                        break;
                    default:
                        break;
                }
            }

            return list.Sum(x => x);
        }

        public static int RomanToIntBetterVersion(string s)
        {
            int result = 0;
            char[] Roman = s.ToArray();
            for (int i = 0; i < Roman.Length; i++)
            {
                switch (Roman[i])
                {
                    case 'M':
                        result += 1000;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'C':
                        result += 100;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'X':
                        result += 10;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'I':
                        result += 1;
                        break;
                }
            }
            if (s.Contains("CD") || s.Contains("CM"))
                result -= 200;
            if (s.Contains("XL") || s.Contains("XC"))
                result -= 20;
            if (s.Contains("IV") || s.Contains("IX"))
                result -= 2;


            return result;
        }

        public static int RomanToIntConciseVersion(string s)
        {
           

                int curr = 0;

                for (int i = 0; i < s.Length; i++)
                {

                    switch (s[i])
                    {
                        case 'I':
                            curr += 1;
                            if (i + 1 < s.Length)
                            {
                                if (s[i + 1] == 'V')
                                {
                                    curr += 3;
                                    i++;
                                }
                                else if (s[i + 1] == 'X')
                                {
                                    curr += 8;
                                    i++;
                                }
                            }
                            break;

                        case 'V':
                            curr += 5;
                            break;

                        case 'X':
                            curr += 10;
                            if (i + 1 < s.Length)
                            {
                                if (s[i + 1] == 'L')
                                {
                                    curr += 30;
                                    i++;
                                }
                                else if (s[i + 1] == 'C')
                                {
                                    curr += 80;
                                    i++;
                                }
                            }
                            break;

                        case 'L':
                            curr += 50;
                            break;

                        case 'C':
                            curr += 100;
                            if (i + 1 < s.Length)
                            {
                                if (s[i + 1] == 'D')
                                {
                                    curr += 300;
                                    i++;
                                }
                                else if (s[i + 1] == 'M')
                                {
                                    curr += 800;
                                    i++;
                                };
                            }
                            break;

                        case 'D':
                            curr += 500;
                            break;

                        case 'M':
                            curr += 1000;
                            break;

                        default:
                            break;
                    }
                }

                return curr;
            
        }

        public static int RomanToIntWithDict(string s)
        {
            if (s == null || s == string.Empty)
                return 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            int result = 0;

            dict.Add("I", 1);
            dict.Add("V", 5);
            dict.Add("X", 10);
            dict.Add("L", 50);
            dict.Add("C", 100);
            dict.Add("D", 500);
            dict.Add("M", 1000);
            dict.Add("IV", 4);
            dict.Add("IX", 9);
            dict.Add("XL", 40);
            dict.Add("XC", 90);
            dict.Add("CD", 400);
            dict.Add("CM", 900);

            for (int i = 0; i < s.Length; i++)
                if ((s[i] == 'I' || s[i] == 'X' || s[i] == 'C') && i < s.Length - 1 && dict.ContainsKey(s.Substring(i, 2)))
                    result += dict[s.Substring(i++, 2)];
                else
                    result += dict[s[i].ToString()];

            return result;
        }
    }
}
