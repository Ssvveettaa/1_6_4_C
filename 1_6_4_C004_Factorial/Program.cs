// 1_6_4_C004_Factorial:

double Factorial(int n)
{
    // 0! = 1
    // 1! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i, 2}! = {Factorial(i)}"); // 3! = 1 * 2 * 3 = 6
}
