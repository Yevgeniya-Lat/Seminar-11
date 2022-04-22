/*
Задача 3: 
Разложите число на множители. Желательно использовать рекурсию:

N = 12 -> "2, 2, 3"

*/


int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

/*
void PrintNumber (int number, int k = 2) // тоже работает
{
    if (number > 2)
    {
        if (number == k) System.Console.WriteLine(k + " ");
        else if (number % k == 0)
        {
            number = number / k;
            System.Console.Write(k + " ");
            PrintNumber(number);
        }
        else
        {
            PrintNumber( number, ++k);
        }
    }
}*/

void PrintNumber (int number, int k = 2)
{
    if (number/2 < k) 
    {
        System.Console.Write(number);
        return;
    }    
    if (number % k == 0)
    {
        System.Console.Write(k + " ");
        PrintNumber(number/k, k);
    }
    else PrintNumber(number, k+1);
}
 
int N = Prompt("Введите N:  ");
System.Console.WriteLine();
PrintNumber(N);
