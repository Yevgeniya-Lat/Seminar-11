/*
Задача 5: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 

m = 3, n = 2 -> A(m,n) = 29

*/



int Prompt(string massage)
{
    System.Console.Write(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

/*  int Akkerman(int n, int m) // работает до n = 1  и m = 4 => пишет переполнен сток
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    return Akkerman(n - 1, Akkerman(n, m - 1));
}

*/

    int Akker (int n, int m)
{
    int temp = 0;
    if (m == 0) return n = n + 1;
    if (m == 1) return n = (n + 1) + 1;
    if (m == 2) return n = 2 * (n + 3) - 3;
    if (m == 3)  temp = n + 3; 
    return n = 2 ^ temp - 3;

    return Akker(n, m);
}    

/*  int A(int n, int m) // работает, но так же переполняется быстро
            {
                if (n == 0) return m + 1;
                if (n > 0 && m == 0) return A(n - 1, 1);
                if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
                return A(n,m);
            }
*/

int N = Prompt("Введите n => "); // n должна быть столбцом
int M = Prompt("Введите m => "); // m должна быть строкой

//Console.Write(Akkerman(M, N));

//System.Console.WriteLine(A (M, N));

System.Console.WriteLine(Akker(N, M));
