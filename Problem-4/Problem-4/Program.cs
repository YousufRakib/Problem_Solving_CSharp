using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter which ondex value you want to see from lost :");
            //int index = Convert.ToInt32(Console.ReadLine());

            int index = 10;
            Console.WriteLine(" Your serching Index is : {0} & Element is : {1}", index, dblLinear(index)); 
            
            Console.ReadLine();

        }

        public static int dblLinear(int parameterValue)
        {
            List<int> uList = new List<int>();

            //Console.WriteLine("Please enter, how many time you want to add value in the list :");
            //int noOfTimeAddValue = Convert.ToInt32(Console.ReadLine());
            int noOfTimeAddValue = 7;


            int firstValueInList = 1;
            uList.Add(firstValueInList);

            for (int i = 1; i <= noOfTimeAddValue; i++)
            {
                var firstConditionValue = 2 * firstValueInList + 1;
                uList.Add(firstConditionValue);

                var secondConditionValue = 3 * firstValueInList + 1;
                uList.Add(secondConditionValue);

                uList.Sort();

                firstValueInList = uList[i];

            }
            uList.Sort();

            string listElements = "";

            Console.WriteLine(" List Elements : ");
            foreach (int item in uList)
            {
                listElements = listElements+" "+ item;
            }
            Console.WriteLine(listElements,"\n");

            return uList[parameterValue];
        }
    }
}
