// Имеется одноименный массив aray из n элементов. Требуется найти элемент массива, равный find 
//(найти индекс)
//1.становить счетчик index в позицию ноль.
//2.Если array[index] == find, флгоритм завершил работу успешно
//3.Увеличить index на 1
//4.Если  index < n,  то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно
int [] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
if(array[index] == find)
{
    Console.WriteLine(index);
    break;
}

    index = index + 1;
}