using System;

namespace CodeKata
{
    public class StringCalculator
    {
        public int add(string number) 
        {
            if(number=="") return 0;
            string extraSplitter=",";
            if(number.Contains("//"))
            {
                var toextraString=number.Split(new string[] { "//" }, StringSplitOptions.None);
                extraSplitter = toextraString[1][0].ToString();
                number = toextraString[1].Substring(1);
            }           
            string[] numbers = number.Split(new string[] { "\r\n", "\n",",",extraSplitter }, StringSplitOptions.None);
            int result = 0;
            foreach(string item in numbers)
            {
                if (item.Contains("-")) throw new ArgumentException();
                if (item.Length<4) { result += Int32.Parse(item); } //item must be smaller than 1000          
            }
            return result;
        }
    }
}
