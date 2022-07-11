// Задача 3.

// Простые делители числа 13195 - это 5, 7, 13 и 29.

// Каков самый большой делитель числа 600851475143, являющийся простым числом? 

long bigNumber = 600_851_475_143;

for (long divider = 2; divider < bigNumber; divider++)
    if (bigNumber % divider == 0)
    {
        long tesPrime = bigNumber / divider;
        if (IsPrime(tesPrime))
        {
            Console.WriteLine("Найбольший делитель числа {0}, являющийся простым числом равен {1}", bigNumber, tesPrime);
            break;
        }
    }
      

bool IsPrime(long number)
{
    if (number != 2 && number % 2 == 0) return false;
    if (number != 3 && number % 3 == 0) return false;
    if (number != 5 && number % 5 == 0) return false;

    long divider = (number / 2) + 1;

    while (divider > 2)
    {
        if (number % divider == 0)
            return false;

        divider--;
    }

    return true;
}