using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithm
{
    class FindFirstRepeatedChar
    {
        public static char GetFirstRepeatedChar(string input)
        {
            //a green apple
            var charArray = input.Replace(" ", "").ToCharArray();
            var dic = new Dictionary<char, int>();
            foreach (var item in charArray)
            {
                if (dic.ContainsKey(item))
                {
                    var getCount = dic[item];
                    dic.Remove(item);
                    dic.Add(item, getCount + 1);
                }
                else
                {
                    dic.Add(item, 1);
                }
            }

            foreach (var item in charArray)
            {
                var getValue = dic[item];
                if (getValue == 1)
                {
                    return item;
                }
                
            }
            return ' ';
        }
    }
}
