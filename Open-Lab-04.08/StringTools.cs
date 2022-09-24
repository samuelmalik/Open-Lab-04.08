using System;
using System.Linq;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int loopsNumber = 0;
            int x = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    loopsNumber++;
                }
            }
            string[] newArray = new string[loopsNumber];

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    newArray[x] = strings[i];
                    x++;
                }
            }
            return newArray;
        }
    }
}
