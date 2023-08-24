// 1_6_4_C001_Table:

// String.Empty – По умолчанию для строк инициализация происходит с этой константой (пустой строкой).
//    1:            2:            3:            4:            5:
// 1: table[0, 0]   table[0, 1]   table[0, 2]   table[0, 3]   table[0, 4]
// 2: table[1, 0]   table[1, 1]   table[1, 2]   table[1, 3]   table[1, 4]

//                GetLength: 0  1 – порядковый номер размерности массива.
string[,] table = new string[2, 5];
table[1, 2] = "Слово";
OutputTable(table);

void OutputTable(string[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++) // rows – для строк. В "GetLength", 0 – строки.
    {
        for (int columns = 0; columns < tab.GetLength(1); columns++) // columns – для столбцов. В "GetLength", 1 – столбцы.
        {
            Console.Write($"–{tab[rows, columns], 8}–   "); // {variable, 4}
        }
        Console.WriteLine();
    }
}
