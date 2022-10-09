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
            Kata.Withdraw(230);
        }
    }

    public static class Kata
    {
        public static int[] Withdraw(int n)
        {
            int[]res = new int[3];
            int oneHundred = 0;
            int fifty = 0;
            int twenty = 0;
            while(n!=0)
            {
              
                if(n%100==0)
                {
                    n -= 100;
                   oneHundred++;
                }
                else if (n%50==0)
                {
                    n-=50;
                    fifty++;
                }
                else
                {
                    n -= 20;
                    twenty++;
                }
            }
            
                res[0] = oneHundred;
                res[1] = fifty;
                res[2] = twenty;
            
            return res;


        }
    }
}
