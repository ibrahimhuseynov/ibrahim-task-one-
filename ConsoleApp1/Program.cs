using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 23, 34 };
         foreach (int i in number(ref arr, 11))
            {
                Console.WriteLine(i);
                Console.Read();
            } 
           
        }
        static int[] number(ref int[] arr,int num)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                int s = arr[i] + num;
                
            }
           return arr;
        }
    }
}
