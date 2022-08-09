namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] firstArray = new int[4, 3, 2]
            {

                { { 4, 5 }, { 8, 6 }, { 8, 7 } },
                { { 4, 5 }, { 8, 6 }, { 8, 7 } },
                { { 4, 5 }, { 8, 6 }, { 8, 7 } },
                { { 4, 5 }, { 8, 6 }, { 8, 7 } },
            };

            int[,,] secondArray = new int[4, 3, 2]
           {

                { { 7, 8 }, { 6, 5 }, { 3, 5 } },
                { { 7, 8 }, { 6, 5 }, { 3, 5 } },
                { { 7, 8 }, { 6, 5 }, { 3, 5 } },
                { { 7, 8 }, { 6, 5 }, { 3, 5 } },
           };
            int[,,] answer = new int[4, 3, 2];
            for (int x = 0; x < firstArray.GetLength(0); x++)
            {
                for (int y = 0; y < firstArray.GetLength(1); y++)
                {
                    for (int z = 0; z < firstArray.GetLength(2); z++)
                    {
                        answer[x, y, z] += secondArray[x, y, z] * firstArray[x, y, z];
                        Console.WriteLine(answer[x, y, z]);
                    }

                }


            }




        }
    }
}