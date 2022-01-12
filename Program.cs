using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA12_EstimatingPi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("\nPi value from Math.PI function: " + Math.PI);
            Console.Write("=== Estimated Pi based on user input number of terms (n) === \nEnter number of terms, n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Estimated Pi at {0} terms is {1}", n, CalPi(n));

            Console.WriteLine("\n==== Finding number of terms (k) that starts to stabilize the pi value. ==== \nDefined: Pi value is stabilized when the value of the k term is less than 1e-6");

            double k=1; 
            int m = Convert.ToInt32(Terms(k));
            Console.WriteLine("The term k is: " + m);
            double Tolerance2 = 4 / (2 * Terms(k) + 1);
            Console.WriteLine("Value of the term k is: " + Tolerance2);
            Console.WriteLine("Estimated Pi with {0} terms is {1}", m, CalPi(m));
            Console.ReadLine();
        }

        private static double Terms(double k)
        {
            double tolerance = 1.000;
            
            while (tolerance > 1e-6)
            {
                tolerance = 4 / (2 * k + 1);
                k++;
            }
            k -= 1;
            return k;
        }

        private static double CalPi(int n)
        {
            int i;
            double pi;
            double deno;

            pi = 0;

            for (i = 0; i < n; i++)
            {
                deno = (i * 2 + 1);

                if (i % 2 == 0)
                {
                    pi = pi + (1 / deno);
                }
                else
                {
                    pi = pi - (1 / deno);
                }
            }
            return pi = 4 * pi;
        }

    }
}
