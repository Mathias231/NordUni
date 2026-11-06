# Course 2 Showcase
In this folder I want to showcase my work before and after delivery



## Task 1: The Player Inventory
Expected Console Flow:
```
=== Starting Inventory ===
1. Wooden Sword
2. Health Potion
3. Map
4. Shield
5. Bread
```

Here is what I delivered:
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


## Task 2: High Score Analyzer

## Task 3: Area of Effect (AoE) Damage

## Task 4: The 2D Level Grid

## Task 5: Spawning the Enemy Wave

## Bonus Exercise: The Dynamic Loot Bag
