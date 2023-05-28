using System.Diagnostics;
using System;

namespace OddNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a max number to display all of odd number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num;  i+=2) 
            {
                Console.WriteLine(i);    
            }
            Console.WriteLine("************Another Way************");
            for(int j = 1; j <= num; j++) 
            {
                if(j%2 != 0)
                {
                    Console.WriteLine($"{j} ");
                }
            }
            string output = "";
            for (int i = 1; i <= num; i += 2)
            {
                output += i + " ";
            }
            Console.WriteLine(output);
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int j = 1; j <= num; j++)
            {
                if (j % 2 != 0)
                {
                    sb.Append(j + " ");
                }
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();

        }
        
    }
}