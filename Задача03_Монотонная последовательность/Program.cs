/*
Задача 1: 
Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
Выведите ряд этой последовательности до N-го значения, желательно использовать :

N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

*/


int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}


void PrintNumber (int number, int k = 1, int m = 0)
{
    for ( int i = 0; i < k; i++)
    {
        System.Console.Write(k + " ");
        m++;
        if (m == number)
        return;
    }
    PrintNumber(number, k + 1, m);
}

int N = Prompt("Введите N:  ");
System.Console.WriteLine();
PrintNumber(N);
