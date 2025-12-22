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
                Console.Write("Enter a whole number: ");
                num = int.Parse(Console.ReadLine());
                for (i = 2; i < num; i++)
                {
                    if (num % i == 0) {
                        sum += i;
                    }
                }
                if (sum == num)
                {
                    Console.Write($"{num} is a perfect number:\n{num}=1");
                    for (i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            Console.Write($"+{i}"); ;
                        }
                    }
                    Console.WriteLine();
                }
                else { Console.WriteLine($"{num} is not a perfect number."); }
                */
                /*Question 54 - Letters
                char ch=' ', ch1; int count=0; string x;
                Console.Write("Enter a character (#1): ");
                ch1 = Console.ReadLine()[0];
                for(int i = 2; i <= 25; i++){if (ch == ch1) count++;
                    Console.Write($"Enter a character (#{i}): ");
                    ch = Console.ReadLine()[0];}
                Console.WriteLine($"{count} characters were identical to the first character inputted.");*/

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

                /* Question 63 - Numbers
                int n, sum, cur, prev, i = 1, mid, midi, mindif, n2 = 0, n1 = 0;
                mindif = int.MaxValue;
                Console.Write("How many numbers?(odd number): ");
                n = int.Parse(Console.ReadLine());
                while (n % 2 == 0) { 
                    Console.Write("Again, ODD number: ");
                    n = int.Parse(Console.ReadLine()); 
                }
                n = Math.Abs(n);
                midi = (n+1)/2;
                Console.Write($"Enter a number(#{i}): ");
                prev = int.Parse(Console.ReadLine());
                sum = prev;
                mid = midi == 1 ? prev : 0;
                for (i = 2; i <= n; i++){
                    Console.Write($"Enter a number(#{i}): ");
                    cur = int.Parse(Console.ReadLine());
                    sum += cur;
                    if (i == midi) mid = cur;
                    if (cur - prev < mindif){
                        mindif = cur - prev;
                        n1 = cur; n2 = prev;
                    }
                    prev = cur;
                }
                Console.WriteLine($"Average: {Math.Round((sum/1.0/n),2)}");
                Console.WriteLine($"Middle number: {mid}");
                Console.WriteLine($"Closest pair: {n1} & {n2}");
                */
                /*Question 59 - 1+2+3+....+n=?
                int n, i, sum = 0;
                Console.Write("Enter a number: ");
                n=int.Parse(Console.ReadLine());
                for (i = 1; i < n; i++){
                    Console.Write($"{i}+");
                    sum += i;
                }
                Console.Write($"{n}={sum+n}\n");*/

                /*Question 42 - Average
                int i,n1=0,n2=0,sum=0;
                for (i = 1; i <= 20; i++){
                    Console.Write($"(#{i}) Enter first number: ");
                    n1= int.Parse(Console.ReadLine());
                    Console.Write($"(#{i}) Enter second number: ");
                    n2 = int.Parse(Console.ReadLine());
                    if (n1 >= n2) sum += n1; else sum += n2;
                }
                Console.WriteLine($"Average of the larger numbers of each pair: {Math.Round(sum/20.0,2)}");
                */
                /*Question 43 - Car race
                int i,sum=0, plate, time, cund4=0; string sund4 = "";
                for (i = 1; i <= 40; i++){
                    Console.Write($"Car #{i}, Enter plate number: ");
                    plate = int.Parse(Console.ReadLine());
                    Console.Write($"Car #{i}, Enter your time in seconds: ");
                    time = int.Parse(Console.ReadLine());
                    if (time>300) Console.WriteLine($"You will not advance to the final stage.");
                    if (time < 240){
                        cund4++;
                        sund4 += $"{plate}, ";
                    }
                    sum += time;
                }
                Console.WriteLine($"Under 4 minutes: {sund4}");
                Console.WriteLine($"Average time: {Math.Round(sum/40.0,2)}");
                */
                /*Question 44 - Exponentiation
                double num,exp,sum=1;
                Console.Write("Enter the base number: ");
                num = int.Parse(Console.ReadLine());
                Console.Write("Enter the exponent: ");
                exp = int.Parse(Console.ReadLine());
                if (exp!=0) for (int i = 1; i <= Math.Abs(exp); i++) sum *= num;
                if (exp<0) sum = 1.0/sum;
                Console.WriteLine($"{num}^{exp}={sum}");
                */
                c = Console.ReadKey(true);
            }
        }
    }
}
