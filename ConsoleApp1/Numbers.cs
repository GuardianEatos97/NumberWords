using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WordNumbers
{
    internal class Numbers
    {
        public static string WordNums(int num)
        {
            string[] singledigits = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",};
            string[] smalldualdigits = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tensstring = {"", "",  "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            if (num > 0 & num <10)
            {
                return singledigits[num];
            }
            else if (num == 0) 
            {
                return "zero";
            }

            else if (num >= 10 & num <20) 
            {
                return smalldualdigits[num-10];
            }

            else if (num >= 20 & num < 100)
            {
                return tensstring[num / 10] + " " + singledigits[num % 10]; 
            }

            else if (num >= 100 & num <= 999) 
            {
                if (num % 10 == 0)
                {
                    
                }
                return singledigits[num/100] + " hundred" + " " + tensstring[num%100/10] + " " + tensstring[num%10];

                
            }

            return "";
        }
        
    }
    
}
