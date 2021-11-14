using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecFlowFrameworkDemo.Pages
{
    class Occouance
    {
        
        public static void Main()
        {
            string input = "Hellowworld";
            Dictionary<char, int> newmap = new Dictionary<char, int>();
       
            for (int i = 0; i < input.Length; i++)
            {
                if (newmap.ContainsKey(input[i]))
                {
                    newmap.Add(input[i], newmap.GetValueOrDefault(input[i]) + 1);
                }
                else
                {
                    newmap.Add(input[i], 1);

                }

            }

            int maxvalue = newmap.Values.Max();
 
            foreach(var value in newmap)
            {
                if(value.Value== maxvalue)
                {
                    Console.WriteLine(value.Key);
                }
            }
        }
        
    }
}
