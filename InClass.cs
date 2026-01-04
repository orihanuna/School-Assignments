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
            int n, i, highestI, highestG=0,num,sumF=0,sumA=0,cA=0,cF=0;
            Console.Write("How many students are there?: ");
            n=int.Parse(Console.ReadLine());
            for (i=1;i<=n;i++) {
                Console.Write($"Student #{i}, enter your grade: ");
                num= int.Parse(Console.ReadLine());
                if (num<55) { sumF += num; cF++; }
                if (num>=95) { sumA += num; cA++; }
                if (num > highestG) { highestG = num; highestI = i; }
            }
            Console.WriteLine($"Average of failing grades: {(double)sumF/cF}");
            Console.WriteLine($"Average of perfect scores: {(double)sumA/cA}");

        }
    }
}
