/*
Задача 4: 
Разверните число при помощи рекурсии:

N = 1234 -> "4321"

*/


int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

void Reverse(int number)
        {
            int newNum = number % 10;
            Console.Write(newNum);
            number /= 10;
 
            if (number > 0)
                Reverse(number);
        }


int N = Prompt("Введите N:  ");
System.Console.WriteLine();
Reverse(N);
