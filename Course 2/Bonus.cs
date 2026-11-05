List<string> playerInv = new List<string>();

playerInv.Add("Gold Coin");
playerInv.Add("Health Potion");
playerInv.Add("Rusty Key");

// Print Starting Loot
Console.WriteLine("=== Starting Loot ===");
foreach (string item in playerInv)
{
    Console.WriteLine($"-{item}");
}


// Adding Magic Sword to bag and print
Console.WriteLine("\nYou found a Magic Sword! Adding to bag...\n=== Updated Loot ===");
playerInv.Add("Magic Sword");

foreach (string item in playerInv)
{
    Console.WriteLine($"-{item}");
}

// Drink health potion and print bag
Console.WriteLine("\nYou Drank the Health Potion.\n=== Final Loot ===");
playerInv.Remove("Health Potion");

foreach (string item in playerInv)
{
    Console.WriteLine($"-{item}");
}


// What I would do differently
// List<string> playerInv = new List<string>();

// playerInv.Add("Gold Coin");
// playerInv.Add("Health Potion");
// playerInv.Add("Rusty Key");

// void PrintPlayerInventory()
// {
//     foreach (string item in playerInv)
//     {
//         Console.WriteLine($"-{item}");
//     }
// }

// // Print Starting Loot
// Console.WriteLine("=== Starting Loot ===");
// PrintPlayerInventory();


// // Adding Magic Sword to bag and print
// Console.WriteLine("\nYou found a Magic Sword! Adding to bag...\n=== Updated Loot ===");
// playerInv.Add("Magic Sword");
// PrintPlayerInventory();

// // Drink health potion and print bag
// Console.WriteLine("\nYou Drank the Health Potion.\n=== Final Loot ===");
// playerInv.Remove("Health Potion");
// PrintPlayerInventory();