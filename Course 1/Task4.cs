namespace multiplicationTableGenerator
{
    class Task4
    {
        static void Main()
        {
            Console.WriteLine("Enter a number for the multiplication table: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("--- Multiplication Table for 7 ---");
            for(int i = 1; i < 11; i++){Console.WriteLine($"{userInput} x {i} = {userInput * i}");}
        }
    }
}

