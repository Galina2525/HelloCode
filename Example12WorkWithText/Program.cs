// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить 
//большими "К", а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// sring s = "abcd"
//            012
// s[1] // b
// s[2] // c
// пишем метод stringReplace
string Replace(string text, char oldValue, char newValue) // char - конкретный символ
{
    string result = String.Empty; // инициализация пустой строки

    int length = text.Length; // длина новой строки (нового текста) равна длине исходного текста
    for (int i = 0; i < length; i++)
    {
       if (text[i] == oldValue ) result = result + $"{newValue}";//новое значение в виде строки 
       //если символ совпадает
       else result = result + $"{text[i]}"; //текущий символ, если совпадений не обнаружено
    }


    return result;
}
string newText = Replace(text, ' ',  '|'); //пробелы заменяем на черточки
Console.WriteLine(newText);
Console.WriteLine(); //пустая строка
newText = Replace(newText, 'к',  'К'); //маленькие заменяем на большие
Console.WriteLine(); //пустая строка
newText = Replace(newText, 'С',  'с'); //маленькие заменяем на большие