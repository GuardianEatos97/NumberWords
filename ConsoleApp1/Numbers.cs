using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
                if ( num%100 >=10 & num%100 <=19)
                {
                    return singledigits[num / 100] + " Hundred" + " " + smalldualdigits[num%10];
                }
                else if (num%10 >= 1 & num%10 <10) 
                {
                    return singledigits[num / 100] + " Hundred" + " " + tensstring[num % 100 / 10] + " " + singledigits[num % 10];
                }
                 

                return singledigits[num/100] + " Hundred" + " " + tensstring[num%100/10] + " " + tensstring[num%10];

                
            }
            else if (num >= 1000 &  num <= 9999)
            {
                if (num % 1000 >= 100 & num % 1000 <= 999)
                {
                    if (num % 1000 == 0)
                    return singledigits[num / 1000] + " Thousand";
                    else if (num % 1000 > 0 & num % 1000 < 1000)
                    {
                        if (num % 10 <= 0 & num % 10 < 10)
                        {
                            return singledigits[num / 1000] + " Thousand" + " " + singledigits[(num % 1000 / 100)] + " Hundred" + " " + singledigits[num % 10];
                        }
                        else if (num % 100 >= 10 & num % 100 < 20)
                        {
                            return singledigits[num / 1000] + " Thousand" + " " + singledigits[(num % 1000 / 100)] + " Hundred" + " " + smalldualdigits[num % 10];

                        }
                        else if (num % 100 >= 20 & num % 100 < 100)
                        {
                            return singledigits[num / 1000] + " Thousand " + singledigits[num % 1000 / 100] + " Hundred " + tensstring[num % 100 / 10] + " " + singledigits[num % 10];
                        }
                    }

                }

                else if (num % 1000 >= 10 & num % 1000 <= 19)
                {
                    return singledigits[num / 1000] + " Thousand" + " " + smalldualdigits[num % 10];

                }
                else if (num % 10 >= 0 & num % 10 <= 9)
                {
                    return singledigits[num / 1000] + " Thousand" + " " + tensstring[num % 100/10] + " " + singledigits[num%10];
                }
                    return singledigits[num / 1000] + " Thousand" + " " + singledigits[(num / 1000)] + " Hundred";

            }


            return "";
        }
        
    }
    
}
