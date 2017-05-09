using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cash_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money_type = new int[] {100,50,20,10,5 };
            int n = Convert.ToInt32(Console.ReadLine());
            int k;
            int type_count = 0;

            if (n % 5 != 0)
            {
                Console.WriteLine("-1");
            }

            else
            {
                while (n != 0)
                {
                    for (int i = 0; i < money_type.Length; i++)
                    {
                        k = n / money_type[i];
                        n %= money_type[i];
                        type_count += k;
                    }
                }
                Console.WriteLine(type_count);
            }

            Console.ReadKey();
        }
    }
}
