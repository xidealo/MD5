using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMD5
{
    public  class FindMD5
    {
        string hash;

        static string ToBinaryString(Encoding encoding, string text)
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        public string GetHash(string data)
        {
            var binaryString = StepOne(data);
            
            


                return hash;
         
        }

        public string StepOne(string data)
        {
            var text = ToBinaryString(Encoding.UTF8, data);

            text = (text.Length < 448) ? text + '1' : text;

            while (text.Length < 448)
            {
                text += "0";
            }

            return text;
        }   
    }
}
