using System.Threading.Channels;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*question 15
            double hrate, hday, hnight, hshab, wage; //var init
            Console.WriteLine("Enter (in that order): Hourly Rate, Hours Worked(day), Hours Worked(night), And Hours Worked(shabbat).");
            hrate = double.Parse(Console.ReadLine()); //4 lines input
            hday = double.Parse(Console.ReadLine());
            hnight = double.Parse(Console.ReadLine());
            hshab = double.Parse(Console.ReadLine());
            wage = (hday * hrate) + (hnight * (hrate * 1.50)) + (hshab * (hrate * 2.0)); //calc total wage, nightrate is 150% of dayrate and shabrate is 200% of dayrate
            Console.WriteLine($"Your Total Wage is {Math.Round(wage,2)}"); //final output
            Console.ReadKey(); //keep window open
            */
            /*question 16
            int years; double hours, days, seconds; //var init
            Console.Write("Enter your age in years: "); //req input
            years = int.Parse(Console.ReadLine()); //input
            days = years * 365.25; //3 lines calc days hours years
            hours = days*24;
            seconds = hours * 3600; 
            Console.WriteLine($"Your age is {years} years, which are also:\n{days} days,\n{hours} hours,\nOr {seconds} seconds."); //final output
            Console.ReadKey(); //keep window open
            */

            /*30.10 Q2
            int set1, set2, diff; //var init
            Console.WriteLine("Enter Hour, Minute, Second #1:");
            set1 = int.Parse(Console.ReadLine())*3600; //first set inputs
            set1 += int.Parse(Console.ReadLine())*60;
            set1 += int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hour, Minute, Second #2:");
            set2 = int.Parse(Console.ReadLine()) * 3600; //second set inputs
            set2 += int.Parse(Console.ReadLine()) * 60;
            set2 += int.Parse(Console.ReadLine());
            diff = set2 - set1; // calc difference
            Console.WriteLine($"The difference between the times is {diff/3600}:{(diff%3600)/60}:{diff%60}"); //final output
            Console.ReadKey(); //keep window open
            */

            /*if else 6.11
            Console.Write("Enter A Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter A Number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 <= num2) { Console.WriteLine($"{num1} {num2}\n{num2} {num1}"); }
            else { Console.WriteLine($"{num2} {num1}\n{num1} {num2}"); }
            */
            /* in class four liner
            Console.Write("Enter number of students going to the trip then ship capacity: "); 
            int stu = int.Parse(Console.ReadLine());
            int shipcap = int.Parse(Console.ReadLine()); 
            Console.WriteLine($"Price for {stu/shipcap + (stu%shipcap!=0 ? 1 : 0)} ships is {(stu / shipcap + (stu % shipcap != 0 ? 1 : 0)) * 60}$");
            Console.ReadKey();
            */
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
        Console.WriteLine(num1 + " " + num2);
            }
            else
            {
        Console.WriteLine(num2 + " " + num1);
            }
                Console.WriteLine("hu zorek milim la'avir");
            
        }
    }
}
