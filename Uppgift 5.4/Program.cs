using System;
namespace uppgift5._4
{
    class program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            namn[0] = "Albin";
            namn[1] = "Theodor";
            namn[2] = "Melker";
            namn[3] = "Anton";
            namn[4] = "Felix";

            for (int i = 0; i < namn.Length; i++)
            {
                Array.Sort(namn);

                Console.WriteLine(namn[i]);
            }
        }
    }
}