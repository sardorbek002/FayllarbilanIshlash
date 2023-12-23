using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_5_Modul;

public class SecondTask
{
   
    public void DeferredExecution()
    {
          Random random=new();
    Console.WriteLine("Massiv o'lchamini Kiriting :");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] array=new int[n];
        for(int i=0;i<n;i++)
        {
            array[i]=random.Next()%10;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine("\nNatija =====================");
        for(int i = 0; i < n;i++)
        {
            if (array[i] > 5)
            {
                Console.Write(array[i]+" ");
            }
        }
    }


    public void ImmediateExecution()
    {
        Random random = new();
        Console.WriteLine("Massiv o'lchamini Kiriting :");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next() % 10;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\nNatija =====================");
        for (int i = 0; i < n; i++)
        {
            if (array[i] < 5)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
