using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int grade = rng.Next(1, 6);
            Console.WriteLine("Your Grade: {0}", grade);
            Console.ReadKey();
            string txt = "";
            switch (grade)
            {
                case 1: txt = "You should redecide your life....."; break;
                case 2: txt = "You should redecide your life....."; break;
                case 3: txt = "Meh, good enough"; break;
                case 4: txt = "Nice"; break;
                case 5: txt = "NOICE"; break;
                default:
                    txt = "Meow";
                    break;
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(txt);
            ConsoleKeyInfo btn = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Press Backspace");
                btn = Console.ReadKey();
            } while (btn.Key != ConsoleKey.Backspace);
            Console.WriteLine("Press Enter to Add a new grade to file or press S to view the file.");
            btn = Console.ReadKey();

            if (btn.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Adding a new grade");
                StreamWriter file = new StreamWriter(@"..\..\testes.txt", true);
                file.WriteLine(grade + "---" + txt);
                file.Close();

            }
            else if (btn.Key == ConsoleKey.S)
            {
                Console.WriteLine("This is the current info in the file:");
                StreamReader filist = new StreamReader(@"..\..\testes.txt", true);
                string a = filist.ReadToEnd();
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("A Rebel, I see");
            }
            Console.ReadKey();
            //Console.Write("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c=");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\na={0}\nb={1}\nc={2}", a.ToString(), b.ToString(), c.ToString());
            //int[] nums = new int[3] { a, b, c };
            //Console.WriteLine("second number in  the list is {0}", nums[1]);
            //foreach (int i in nums)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine(".(foreach)");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i] + " ");
            //}
            //Console.WriteLine(".(for)\n");
            //string[] texts = new string[4];
            //for (int i = 0; i < texts.GetLength(0); i++)
            //{
            //    Console.Write("{0} text=====", (i + 1).ToString());
            //    texts[i] = Console.ReadLine();
            //}
            //foreach (string item in texts)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine(".\n");
        }
    }
}