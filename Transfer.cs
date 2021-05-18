using System;
using System.Collections.Generic;
using System.Text;

namespace Xtransfer
{
    class Transfer
    {
        public int InputNum { get; set; }
        public string StringNum(string num)
        {
            char[] stringArr=new char[num.Length] ;
            string result=String.Empty;
            int remains;
            int buffInt = int.Parse(num);
            for (int i = num.Length-1; buffInt>0; i--)
            {

            
                remains = buffInt % 16;
                buffInt /= 16;
                if (remains==10)
                {
                    result = "a";
                }
                else if (remains == 11)
                {
                    result = "b";
                }
                else if (remains == 12)
                {
                    result = "c";
                }
                else if (remains == 13)
                {
                    result = "d";
                }
                else if (remains == 14)
                {
                    result = "e";
                }
                else if (remains == 15)
                {
                    result = "f";
                }
                else
                {
                    result = Convert.ToString(remains);
                }
                stringArr[i] = Convert.ToChar(result);
            }
            string str = new string(stringArr);
            return str;
        }
    }
}
