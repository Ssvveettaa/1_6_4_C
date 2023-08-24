// 1_6_4_C002_Matrix:

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10) = [1; 9]
        }
    }
}

void OutputMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // i – для строк. В "GetLength", 0 – строки.
    {
        for (int j = 0; j < matr.GetLength(1); j++) // j – для столбцов. В "GetLength", 1 – столбцы.
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//           GetLength: 0  1 – порядковый номер размерности массива.
int[,] matrix = new int[3, 4];
OutputMatrix(matrix);
Console.WriteLine();

FillMatrix(matrix);
OutputMatrix(matrix);
