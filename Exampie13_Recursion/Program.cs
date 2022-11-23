// ДВУМЕРНЫЕ МАССИВЫ
string[,] table = new string[2,5];
// чтобы обратиться к нужному элементу, указываем наименование массива в [] инд. строки и инд столбца
 //индексы меняются от нуля
 // String.Empty  инициализация строк
 // table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]  
 // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]  
 //

// table[1,2] = "word"; 
// for (int rows = 0; rows < 2; rows ++)
// {
//     for(int columns = 0; columns < 5; columns ++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); 
//     }
// }


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i ++)// ноль в matrix.GetLength(0) означает строки
//     {
//         for(int j = 0; j < matr.GetLength(1); j ++)// единица означает столбцы
//         {
//             Console.Write($"{matr[i, j]} "); 
//         }
//         Console.WriteLine(); 
//     } 
// }
//  void FillArray(int[,] matr)
//  {
//     for (int i = 0; i < matr.GetLength(0); i ++)// 
//     {
//         for(int j = 0; j < matr.GetLength(1); j ++)
//         {
//             matr[i,j] = new Random().Next(1,10); //[1,10)
//         }
        
//     } 
//  }

// int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


//РЕКУРСИЯ - МЕТОД, КОТОРЫЙ ВЫЗЫВАЕТ САМ СЕБЯ
// факториал - произведение чисел от 1 до заданного
// 5! = 5 * 4 * 3 * 2 * 1

// int Factorial (int n)
// {
//     if (n ==1) return 1; // 1! =1  0! ==1
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5)); 

// но при больших цифрах тип int переполняется и высвечиваются отрицательные числа
// Поэтому тип int следует заменить на тип double

double Factorial (double n)
{
    if (n ==1) return 1; // 1! =1  0! ==1
    else return n * Factorial(n - 1);
}
for(double i =1; i < 40; i ++)
{


Console.WriteLine($"{i}! = {Factorial(i)}"); 
}