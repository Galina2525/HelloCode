// Первый метод. Ничего не возврвщвет и ничего на принимает
//
//void Method1()
// {
//     Console.WriteLine("Author");// Console.WriteLine - тело метода, аргумента нет
// }
// Method1();// вызов метода.Не забываем скобки!

// // ВТОРОЙ МЕТОД. Ничего не возвращает, но принимает аргументы
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Text of message");

// void Method2_1(string msg, int count)// аргументы именованные, если аргументов больше одного
// {
//     int i =0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;// инкремент. Если минус один - декремент
//     }
// }
// //Method2_1("Text", 4);
// Method2_1(count: 4, msg:"new text");

// ТРЕТЬЯ ГРУППА методов: что-то возвращает, но ничего не принимает
// Обязательно должны указать тип данных, значения которых мы ожидаем
// int Method3()
// {
//   return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//ЧЕТВЕРТАЯ ГРУППА методов: что-то принимает и что-то возвращает

// string Method4 (int count, string Text)// строку Text будем компоновать count раз
// {
//    int i = 0;
//    string result = String.Empty;// пустая строка
//    while( i< count)
//    {
//     result = result + Text;
//     i++;
//    }
//    return result;
// }

// с циклом FOR это будет выглядеть следующим способом:

// string Method4 (int count, string Text)// строку Text будем компоновать count раз
// {
//    string result = String.Empty;// пустая строка
//    for(int i = 0; i < count; i ++)
//    {
//     result = result + Text;
//    }
//    return result;
// }
// string res = Method4(10,"abcd");
// Console.WriteLine(res);

// ЦИКЛ в ЦИКЛЕ (вывод таблицы умножения на экран)
for(int i = 2; i <= 10; i ++)
{
   for(int j = 2; j <= 10; j ++)
   {
      Console.WriteLine($"{i} x {j} = {i*j}");
   }
   Console.WriteLine();
}


