using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[1];
            firstNames[0] = "mike";
            string[] lastNames = new string[1];
            lastNames = firstNames;

            CustomList<int> list = new CustomList<int>();
            list.Add(12);
            list.Add(13);
            list.Add(14);
        }
    }
}
