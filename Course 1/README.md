# Course 1 showcase
## The Digital ID Card 

```

// Ask for first name
Console.Write("Enter your first name: ");
string firstNameInput = Console.ReadLine();

// Ask for age
Console.Write("Enter your age: ");
int ageInput = int.Parse(Console.ReadLine());

// Ask for middle initial
Console.Write("Enter your middle initial: ");
char initialInput = Console.ReadLine()[0];

// Ask for height in meters
Console.Write("Enter your height in meters (e.g., 1.75): ");
float heightInput = float.Parse(Console.ReadLine());

// DIGICAL ID CARD SETUP
string line = "==============================";
string titleText = "      DIGITAL ID CARD";
string nameText = "Name: " + firstNameInput + " " + initialInput + ".";
string ageText = "Age: " + ageInput;
string heightText = "Height: " + heightInput + "m";


// PRINT
Console.WriteLine(line);
Console.WriteLine(titleText);
Console.WriteLine(line);
Console.WriteLine(nameText);
Console.WriteLine(ageText);
Console.WriteLine(heightText);
Console.WriteLine(line);
```
