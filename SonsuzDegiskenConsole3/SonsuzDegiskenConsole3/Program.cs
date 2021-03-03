using System;

namespace SonsuzDegiskenConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "", y = ""; bool con = false;

            while (con == false)
            {
                Console.Write("Enter first data => ");
                x = Console.ReadLine();
                Console.Write("Enter second data => ");
                y = Console.ReadLine();

                char[] x2 = x.ToCharArray();char[] y2 = y.ToCharArray();
                string x1 = Extract(x2,x); string y1 = Extract(y2, y);

                if (x1 == ""){x1 = "0";}
                if (y1 == ""){y1 = "0";}

                Console.WriteLine("First number => " + x1);
                Console.WriteLine("Second number => " + y1);
                Console.WriteLine("Sum of numbers => " + findSum(x1, y1));
                Console.WriteLine("Process completed.");
                Console.WriteLine(" ");
                Console.WriteLine("New sequence starting...");
            }
        }
        private static string Extract(char[] x2, string x)
        {
            string x1 = "";
            for (int k = 0; k < x.Length; k++)
            {
                if ((int)x2[k] >= 48 && (int)x2[k] <= 52)
                {
                    x1 += x2[k];
                }        
            }
            return (x1);
        }
        static string findSum(string str1, string str2)
            {
                if (str1.Length > str2.Length)
                {
                    string a = str1;
                    str1 = str2;
                    str2 = a;
                }
                string str = "";
                int n1 = str1.Length, n2 = str2.Length;

                char[] ch = str1.ToCharArray();
                Array.Reverse(ch);
                str1 = new string(ch);
                char[] ch1 = str2.ToCharArray();
                Array.Reverse(ch1);
                str2 = new string(ch1);

                int carry = 0;
                for (int i = 0; i < n1; i++)
                {                  
                    int sum = ((int)(str1[i] - '0') + (int)(str2[i] - '0') + carry);
                    str += (char)(sum % 10 + '0');

                    carry = sum / 10;
                }
                for (int i = n1; i < n2; i++)
                {
                    int sum = ((int)(str2[i] - '0') + carry);
                    str += (char)(sum % 10 + '0');
                    carry = sum / 10;
                }
                if (carry > 0)
                {
                    str += (char)(carry + '0');
                }
                char[] ch2 = str.ToCharArray();
                Array.Reverse(ch2);
                str = new string(ch2);

                return str;
            }
        }
    }