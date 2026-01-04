using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class InClass
    {
        static void Main(string[] args) {
            int n, i, highestI, highestG = 0, num, sumF = 0, sumA = 0, cA = 0, cF = 0, hIL, hGL=0 ;
            Console.Write("How many students are there?: ");
            n=int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++) {
                Console.Write($"Student #{i}, enter your grade: ");
                num= int.Parse(Console.ReadLine());
                if (num<55) { sumF += num; cF++; }
                else if (num>=95) { sumA += num; cA++; }
                if (num > highestG) { highestG = num; hGL=num; hIL = i; highestI = i; }
                else if (num == highestG) { hIL = i; highestI = i; }
            }
            Console.WriteLine($"Average of failing grades: {(double)sumF/cF}");
            Console.WriteLine($"Average of perfect grades: {(double)sumA/cA}");
            if (cA > cF) { Console.WriteLine("There are more failing than perfect grades"); }
            else if (cF > cA) { Console.WriteLine("There are more perfect than failing grades"); }
            else { Console.WriteLine("There is the same number of failing and perfect grades"); }
            Console.WriteLine("");
        }
    }
}
