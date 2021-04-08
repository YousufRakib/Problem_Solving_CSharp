using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string sample = "hello world";
            Console.WriteLine("String: " + sample);
            var charLookup = sample.Where(char.IsLetterOrDigit).ToLookup(c => c); // IsLetterOrDigit to exclude the space

            foreach (var c in charLookup)
                Console.WriteLine("{0} - {1}", c.Key, charLookup[c.Key].Count());


            //Or

            string str = "hello world";
            Console.WriteLine("String: " + str);

            str = string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }

            Console.ReadLine();
        }
    }
}
