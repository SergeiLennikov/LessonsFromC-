//Счетчик считает до 10 и выходит из него
// for (int i = 0; i < 100; i++)
// {
//     if (i == 10)
//     {
//         break;
//     }
//     System.Console.WriteLine(i);
// }

//Счетчик пропускает значение 2
// for (int i = 0; i < 5; i++)
// {
//     if (i == 2)
//     {
//         continue;
//     }
//     System.Console.WriteLine(i);
// }


//Рисуем треугольник 
// int height = int.Parse(Console.ReadLine());
// for (int i = 0; i < height; i++)
// {
    
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write("#");
//     }
//     Console.WriteLine();
// }

// Рисуем треугольник в обратном порядке.
// for (int i = 0; i < height; i++)
// {
//     for (int j = height; j > i; j--)
//     {
//         Console.Write("#");
//     }
//     Console.WriteLine();
// }

//Зеркальный Треугольник
// for (int i = 0; i < height; i++)
// {
//     for (int j = height; j > i; j--)
//     {
//         Console.Write(" ");
//     }
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write("#");
//     }
//     Console.WriteLine();
// }

// Зеркальный треугольник на оборот
// for (int i = 0; i < height; i++)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write(" ");
//     }
//      for (int j = height; j > i; j--)
//     {
//         Console.Write("#");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите высоту прямоугольника");
// int height1 = int.Parse(Console.ReadLine());

// Console.Write("Введите Ширину прямоугольника");
// int width = int.Parse(Console.ReadLine());

// for (int i = 0; i < height1; i++)
// {
//     for (int j = 0; j < width; j++)
//     {
//         Console.Write("#");
//     }
//     Console.WriteLine();
// }