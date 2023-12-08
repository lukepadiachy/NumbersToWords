using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    internal class NumberChanger
    {
        string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] unit2 = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] unit3 = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string ConvertNumbersToWords(int number)
        {
            string words = "";

            if (number == 0)
            {
                words = "Zero";
            }
            else
            {
                int[] digitArray = new int[4];
                int holder = number;
                for (int i = 3; i >= 0; i--)
                {
                    digitArray[i] = holder % 10;
                    holder /= 10;
                }

                if (digitArray[0] != 0)
                {
                    words += units[digitArray[0]] + " Thousand ";
                }
                if (digitArray[1] != 0)
                {
                    words += units[digitArray[1]] + " Hundred ";
                }

                int tensPart = digitArray[2];
                int unitsPart = digitArray[3];

                if (tensPart == 1)
                {
                    words += unit2[unitsPart];
                }
                else
                {
                    if (tensPart != 0)
                    {
                        words += unit3[tensPart];
                    }

                    if (unitsPart != 0)
                    {
                        if (tensPart != 0)
                        {
                            words += " "; 
                        }

                        words += units[unitsPart];
                    }
                }
            }

            return words;
        }
    }
}

