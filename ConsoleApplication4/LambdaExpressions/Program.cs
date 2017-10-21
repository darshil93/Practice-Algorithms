using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //List to dictionary
            List<string> list = new List<string>();
            var dictionary = list.GroupBy(str => str)
                .ToDictionary(group => group.Key, group => group.Count());

            //Takes first four elements from the list
            int numberOfOnes = list.Take(4).Count(i => i == "1");

            //returns numbers which are greater than their index.
            int[] numbers = new int[] { 1, 2, 3, 4, 45, 5 };
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

            

        }
    }
}
