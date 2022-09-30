using System;
namespace insertsort
{
    class insertion
    {
        public static void Main (string[] args)
        {
        int[] element = {78,55,45,98,13,39}; 
        int count = element.Length;
        int temp;
        int j=0;
       for (int i = 0; i <count-1 ; i++)

        {

            temp = element [i+1];
            j = i;
            while (j>=0 && temp < element [j])
            {
            element [j+1] = element [j];
            j = j-1;
            }
            element [j+1] = temp;

        }
        for (int i = 0; i <count ; i++)

        Console.WriteLine (element[i]);

        }
    }
}











        






        