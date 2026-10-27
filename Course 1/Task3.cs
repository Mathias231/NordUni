namespace TheLeapYearChecker
{
    class Task3
    {
        static void Main()
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = false;

            if(year % 4 == 0)
            {
                isLeap = true;
                
                if(year % 100 == 0)
                {
                    isLeap = false;       
                    if(year % 400 == 0)
                    {
                        isLeap = true;
                    }
                }
            }
            
            if(isLeap)
            {
                Console.WriteLine($"Result: {year} is a leap year."); 
            } else
            {
                Console.WriteLine($"Result: {year} is not a leap year."); 
            }
        }
    }
}

