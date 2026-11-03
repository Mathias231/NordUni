char[,] board =
{
    {'.', '.', '.' , '.', '.'},
    {'.', '#', '#' , '.', '.'},
    {'.', '.', 'P' , '.', '.'},
    {'.', '.', '.' , '#', '.'},
    {'.', '.', '.' , '.', '.'},
};

Console.WriteLine("Plaintext");

for (int i = 0; i < board.GetLength(0); i++)
{
    for (int j = 0; j < board.GetLength(1); j++)
    {
        Console.Write($"{board[i, j]} ");
    }
    Console.WriteLine();
}