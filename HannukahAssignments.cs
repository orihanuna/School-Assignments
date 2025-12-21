using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HannukahAssignments
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo c = Console.ReadKey(true);
            while (!((c.Modifiers & ConsoleModifiers.Control) != 0 && c.Key == ConsoleKey.Q)){
                /*Question 60 - Coin Toss
                int countL=0,countS=0,i=1;
                bool win= false;
                while (!win)
                {
                    Console.Write($"Round #{i}, Lee's turn(E/P): ");
                    if (Char.ToLower(char.Parse(Console.ReadLine())) == 'e') { countL++; }
                    if (countL == 3) { win = true; }
                    if (!win)
                    {
                        Console.Write($"Round #{i}, Shir's turn(E/P): ");
                        if (Char.ToLower(char.Parse(Console.ReadLine())) == 'e') { countS++; }
                        if (countS == 3) { win = true; }
                        i++;
                    }
                }
                Console.WriteLine($"{(countL==3?"Lee":"Shir")} will start the Checkers match.");
                Console.ReadKey();*/

                /*Question 61 - Perfect Number
                int i, num, sum = 1;
                string output = "1";
                Console.Write("Enter a whole number: ");
                num = int.Parse(Console.ReadLine());
                for (i = 2; i < num; i++)
                {
                    if (num % i == 0) {
                        sum += i;
                        output += $"+{i}";
                    }
                }
                if (sum == num)
                {
                    Console.WriteLine($"{num} is a perfect number.\n{num}={output}");
                }
                else { Console.WriteLine($"{num} is not a perfect number."); }*/

                /*Question 54 - Letters
                char ch=' ', ch1; int count=0; string x;
                Console.Write("Enter a character (#1): ");
                ch1 = Console.ReadLine()[0];
                for(int i = 2; i <= 25; i++){if (ch == ch1) count++;
                    Console.Write($"Enter a character (#{i}): ");
                    ch = Console.ReadLine()[0];}
                Console.WriteLine($"{count} numbers were identical to the first character inputted.");*/

                /*Question 55 - Evened Out
                int num, sum=0, i;
                Console.Write("Enter an even number: ");
                num = Math.Abs(int.Parse(Console.ReadLine()));
                string txt = $"2";
                Console.WriteLine($"Number chosen: {num}\n2");
                for (i = 4; i <= num; i += 2){
                    Console.WriteLine(i); // Part 1
                    sum += i; // Part 2
                    txt += $"+{i}";
                }
                Console.WriteLine($"Sum: {sum}={txt}");*/

                c = Console.ReadKey(true);
            }
        }
    }
}
