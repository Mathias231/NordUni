Console.Write("How many goblins are in this wave? ");
int goblinAmount = int.Parse(Console.ReadLine());

int[] goblinHealthArray = new int[goblinAmount];

Console.WriteLine("\nSpawning wave...");

Random Random = new Random();

// Assign health to each goblin
int i = 0;
while(i < goblinAmount)
{
    goblinHealthArray[i] = Random.Next(10, 25);
    i++;
}

// Print wave and goblins
for (int j = 0; j < goblinAmount; j++)
{
    Console.WriteLine($"Goblin {j + 1} spawned with {goblinHealthArray[j]} HP.");
}