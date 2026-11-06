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

What I would do differently after delivery:
```
string[] inventory = ["Wooden Sword", "Health Potion", "Map", "Shield", "Bread"];

Console.WriteLine("=== Starting Inventory ===");

for (int i = 0; i < inventory.Length; i++)
{
    Console.WriteLine($"{i + 1}. {inventory[i]}");
}

Console.WriteLine($"\nThe player quickly grabs the {inventory[2]} from their bag!");
```

## Task 2: High Score Analyzer

Expected Code Flow:
```
== Analyzing match scores ==
Score: 850
Score: 3200
Score: 1420
...
The highest score achieved was: 5100!
```

Here is what I delivered:
```
int[] score = {850, 3200, 1420, 5100, 900, 2750}; 
int highestScore = 0;

Console.WriteLine("== Analyzing match scores ==");
foreach (var value in score)
{
    Console.WriteLine(value);

    if(value > highestScore)
    {
        highestScore = value;
    }
}
Console.WriteLine($"The highest score achieved was: {highestScore}");
```

What I would do differently after delivery:
```
int[] score = {850, 3200, 1420, 5100, 900, 2750}; 
int highestScore = 0;

Console.WriteLine("== Analyzing match scores ==");
foreach (var value in score)
{
    Console.WriteLine(value);

    if(value > highestScore) highestScore = value;
}

Console.WriteLine($"The highest score achieved was: {highestScore}");
```

## Task 3: Area of Effect (AoE) Damage

Expected Code Flow:
```
Casting Fireball! Dealing 20 damage to all enemies...
Enemy 0 health is now 30
Enemy 1 health is now 10
Enemy 2 health is now 60
Enemy 3 health is now 0 (Defeated!)
```

Here is what I delivered:
```
int[] enemyHealth = {50, 30, 80, 15};
int dmg = 20;

// Title
Console.WriteLine($"Casting Fireball! Dealing {dmg} damage to all enemies..");

for (int i = 0; i < enemyHealth.Length; i++)
{
    // Calculate
    int newEnemyHealth = enemyHealth[i] - dmg;

    // If newEnemyHealth is higher than 0, print health
    if(newEnemyHealth >= 0)
    {
        Console.WriteLine($"Enemy {i} health is now {newEnemyHealth}");
    } else
    {
        Console.WriteLine($"Enemy {i} health is now 0 (Defeated!)");
    }

}
```

What I would do differently after delivery:
```
No personal changes
```

## Task 4: The 2D Level Grid

Expected Code Flow:
```
Plaintext
. . . . .
. # # . .
. . P . .
. . . # .l
. . . . .
```

Here is what I delivered:
```
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
```

What I would do differently after delivery:
```

```

## Task 5: Spawning the Enemy Wave

Expected Code Flow:
```
How many goblins are in this wave? 4
Spawning wave...
Goblin 1 spawned with 14 HP.
Goblin 2 spawned with 22 HP.
Goblin 3 spawned with 10 HP.
Goblin 4 spawned with 18 HP.

```

Here is what I delivered:
```
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

```

What I would do differently after delivery:
```

```

## Bonus Exercise: The Dynamic Loot Bag

Expected Code Flow:
```
=== Starting Loot ===
- Gold Coin
- Health Potion
- Rusty Key

You found a Magic Sword! Adding to bag...
=== Updated Loot ===
- Gold Coin
- Health Potion
- Rusty Key
- Magic Sword

You drank the Health Potion.
=== Final Loot ===
- Gold Coin
- Rusty Key
- Magic Sword
```

Here is what I delivered:
```
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
```

What I would do differently:
```
List<string> playerInv = new List<string>();

playerInv.Add("Gold Coin");
playerInv.Add("Health Potion");
playerInv.Add("Rusty Key");

void PrintPlayerInventory()
{
    foreach (string item in playerInv)
    {
        Console.WriteLine($"-{item}");
    }
}

// Print Starting Loot
Console.WriteLine("=== Starting Loot ===");
PrintPlayerInventory();


// Adding Magic Sword to bag and print
Console.WriteLine("\nYou found a Magic Sword! Adding to bag...\n=== Updated Loot ===");
playerInv.Add("Magic Sword");
PrintPlayerInventory();

// Drink health potion and print bag
Console.WriteLine("\nYou Drank the Health Potion.\n=== Final Loot ===");
playerInv.Remove("Health Potion");
PrintPlayerInventory();
```
