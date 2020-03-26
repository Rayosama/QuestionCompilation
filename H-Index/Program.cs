using System;

namespace H_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int hIndex = CalculateHIndex(arr);
            Console.WriteLine(hIndex);
        }

        static int CalculateHIndex(int[] publicationCitations)
        {
            int hIndex = publicationCitations.Length;
            while (true)
            {
                int numPublications = 0;
                for (int x = 0; x < publicationCitations[x]; x++)
                {
                    if (publicationCitations[x] >= hIndex)
                    {
                        numPublications++;
                    }
                    if (numPublications >= hIndex)
                        break;
                    hIndex++;
                }
                return hIndex;
            }
        }
    }
}
