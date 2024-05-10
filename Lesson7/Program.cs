using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        //Двумерный массив.
        // int[,] aArray = new int[,]{{1,2,3,4,5},{6,7,8,9,1},{10,11,12,13,14}};

        //Вывод двумернорого массива.
        // Random rand = new Random();
        // int[,] myArray = new int[5, 5];

        // int height = myArray.GetLength(0);
        // int width = myArray.GetLength(1);

        // for (int i = 0; i < height; i++)
        // {
        //     for (int j = 0; j < width; j++)
        //     {
        //     myArray[i,j] = rand.Next(1,1000);
        //     Console.Write($"\t{i}.{j} => {myArray[i,j]}");
        //     }
        //     System.Console.WriteLine();
        // }

        //Заполнение двумерного массива с клавиатуры.
        // int[,] arArray = new int[2, 2];

        // for (int i = 0; i < arArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arArray.GetLength(1); j++)
        //     {
        //         arArray[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }

        // for (int i = 0; i < arArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arArray.GetLength(1); j++)
        //     {
        //         Console.Write($"{arArray[i, j]}\t ");
        //     }
        //     Console.WriteLine();
        // }
        // Console.ReadKey();

        // Двумерный строчный массив.

        // string[,] arArray = new string[2, 2];

        // for (int i = 0; i < arArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arArray.GetLength(1); j++)
        //     {
        //         arArray[i, j] = Console.ReadLine();
        //     }
        // }
        // System.Console.WriteLine();
        // for (int i = 0; i < arArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < arArray.GetLength(1); j++)
        //     {
        //         Console.Write($"{arArray[i, j]}\t ");
        //     }
        //     Console.WriteLine();
        // }
        // Console.ReadKey();

        // Зубчатый массив 
        // int [][] artArray = new int[3][];
        // artArray[0] = new int[5];
        // artArray[1] = new int[3]; 
        // artArray[2] = new int[10]; 
        // Random rand = new Random();

        // for (int i = 0; i < artArray.Length; i++)
        // {
        //     for (int j = 0; j < artArray[i].Length; j++)
        //     {
        //         artArray[i][j] = rand.Next(1, 100);
        //     }
        // }
        // for (int i = 0; i < artArray.Length; i++)
        // {
        //     for (int j = 0; j < artArray[i].Length; j++)
        //     {
        //         Console.Write($"{artArray[i][j]}\t");
        //     }
        //     System.Console.WriteLine();
        // }

        //Шести мерный массив.
    //     int[,,,,,,] aaArray = new int[4, 6, 3, 4, 4, 3, 5];

    //    Random rand = new Random();
        
    //     for (int i = 0; i < aaArray.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < aaArray.GetLength(1); j++)
    //         {
    //             for (int k = 0; k < aaArray.GetLength(2); k++)
    //             {
    //                 for (int l = 0; l < aaArray.GetLength(3); l++)
    //                 {
    //                     for (int m = 0; m < aaArray.GetLength(4); m++)
    //                     {
    //                         for (int n = 0; n < aaArray.GetLength(5); n++)
    //                         {
    //                             for (int o = 0; o < aaArray.GetLength(6); o++)
    //                             {
    //                                 aaArray[i, j, k, l, m, n, o] = rand.Next(1000000);
    //                             }
    //                         }
    //                     }
    //                 }
    //             }
    //         }
    //     }
    //     for (int i = 0; i < aaArray.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < aaArray.GetLength(1); j++)
    //         {
    //             for (int k = 0; k < aaArray.GetLength(2); k++)
    //             {
    //                 for (int l = 0; l < aaArray.GetLength(3); l++)
    //                 {
    //                     for (int m = 0; m < aaArray.GetLength(4); m++)
    //                     {
    //                         for (int n = 0; n < aaArray.GetLength(5); n++)
    //                         {
    //                             for (int o = 0; o < aaArray.GetLength(6); o++)
    //                             {
    //                                 Console.Write($"{i},{j},{k},{l},{m},{n},{o} => {aaArray[i, j, k, l, m, n, o]}\t");
    //                             }
    //                             Console.WriteLine();
    //                         }
    //                     }
    //                 }
    //             }
    //         }
    //     }

    //Трех мерный зубчатый массив.
    // Random rnd = new Random();
    //     int[][][] ttAr = new int [rnd.Next(3,6)][][];

    //     for (int i = 0; i < ttAr.Length; i++)
    //     {
    //         ttAr[i] = new int[rnd.Next(2,46)][];
    //         for (int j = 0; j < ttAr[i].Length; j++)
    //         {
    //             ttAr[i][j] = new int[rnd.Next(2,46)];
    //             for (int k = 0; k < ttAr[i][j].Length; k++)
    //             {
    //                 ttAr[i][j][k] = rnd.Next(1,100);
    //             }
    //         }
    //     }
    //     //Вывод массива на экран.

    //     for (int i = 0; i < ttAr.Length; i++)
    //     {
    //         Console.WriteLine("Page №: " + (i + 1));
    //         for (int j = 0; j < ttAr[i].Length; j++)
    //         {
    //             for (int k = 0; k < ttAr[i][j].Length; k++)
    //             {
    //                 Console.Write($"{ttAr[i][j][k]}\t");
    //             }
    //             System.Console.WriteLine();
    //         }
    //         System.Console.WriteLine();








    }

}