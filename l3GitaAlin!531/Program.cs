using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3GitaAlin_531
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a, b, c, m, n1;
            int x, y, z,m1;
           
            float const1;
            const1 = 11.2f;
            int n;
            a = 30;
            b = 24;
            c = 52;
            m = 2;
            n1 = 4;
            Console.WriteLine("a-const = " + ((float)a - const1) + "    a+const = " + ((float)a + const1));
            Console.WriteLine("b-const = " + ((float)b - const1) + "    b+const = " + ((float)b + const1));
            Console.WriteLine("c-const = " + ((float)c - const1) + "    c+const = " + ((float)c + const1));
            n= Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
            Console.WriteLine(i*5+1);
            }
            Console.WriteLine("x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("z=");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max(x ,y ,z)=" + Math.Max(x , Math.Max(y, z)));
            Console.WriteLine("Min(x ,y ,z)=" + Math.Min(x , Math.Min(y, z)));
           
//4
            Console.WriteLine("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array1;
            array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}] ",i+1);
                array1[i] = Convert.ToInt32(Console.ReadLine());  
            }
            Console.WriteLine("max = " + array1.Max());
            Console.WriteLine("min = " + array1.Min());
//5
            Console.WriteLine("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array2;
            array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}] ", i + 1);
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array2);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]={1} ", i + 1, array2[i]);
                
            }
          
            
            
//6
            Console.WriteLine("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            
            array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}] ", i + 1);
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("n= ");
            m1 = Convert.ToInt32(Console.ReadLine());
            
            array1 = new int[m1];
            for (int i = 0; i < m1; i++)
            {
                Console.WriteLine("a[{0}] ", i + 1);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = array2.Concat(array1).OrderBy(op => op).ToArray();
            Console.Write(String.Join(", ", result));
            
            Console.ReadLine();
        }

    }
}
