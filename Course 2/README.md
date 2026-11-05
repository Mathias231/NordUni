# Course 2 Showcase


## Task 1: The Player Inventory
```
Expected Console Flow:
=== Starting Inventory ===
1. Wooden Sword
2. Health Potion
3. Map
4. Shield
5. Bread
```

What I delivered:
```
string[] inventory = ["Wooden Sword", "Health Potion", "Map", "Shield", "Bread"];

string startingLine = "=== Starting Inventory ===";
Console.WriteLine(startingLine);

for (int i = 0; i < inventory.Length; i++)
{
    Console.WriteLine($"{i + 1}. {inventory[i]}");
}

Console.WriteLine($"\nThe player quickly grabs the {inventory[2]} from their bag!");
```
