// Задача 4.

// Число - палиндром с обеих сторон (справа налево и слева направо) читается одинаково.
// Самое большое число-палиндром, полученное умножением двух двузначных чисел – 9009 = 91 × 99.

// Найдите самый большой палиндром, полученный умножением двух трехзначных чисел.

List<int> polindromNumbers = new List<int>();

for(int a = 1; a <= 999; a++)
    for(int b = 1; b <= 999; b++)
        if(IsPolindrom(a * b))
            polindromNumbers.Add(a * b);

Console.WriteLine("Cамый большой палиндром, полученный умножением двух трехзначных чисел равен {0}", polindromNumbers.Max());


bool IsPolindrom(int number)
{
    string stringNumber = number.ToString();

    // Пусть длинна пришедшей 5 => 5 / 2 = 2 (получаем X);
    // 1 . Формируем строку А с 0 по X
    // 2 . Формируем строку Б с Конец строки - X по X
    // 3 . Сравниваем 1 символ А с последним Б, Если символы не равны значит не полиндром

    if(stringNumber.Length == 1) return true;

    int length = stringNumber.Length / 2;
    string firstSubString = stringNumber.Substring(0, length);
    string secondSubString = stringNumber.Substring(stringNumber.Length - length, length);
    
    for(int k = 0; k < length; k++)
    {
        if (!firstSubString[k].Equals(secondSubString[length - 1 - k]))
            return false;
    }

    return true;
}