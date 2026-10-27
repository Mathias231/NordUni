# Course 1 showcase
## Task 1: The Digital ID Card 

> Task: Write a program that asks the user for their personal details and then prints a formatted "ID Card" to the console. You must use the following data types: `string` (name), `int` (age), `char` (initial), and `float` or `double` (height in meters.

Here is what I delivered:
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
Expected Console Flow:
```
Enter your first name: Jane
Enter your age: 19
Enter your middle initial: M
Enter your height in meters (e.g., 1.75): 1.68

==============================
      DIGITAL ID CARD
==============================
Name: Jane M.
Age: 19
Height: 1.68m
==============================
```

What I would do differently after delivery:
```

```

## Task 2: Temperature Converter 
> Task: Create a program that converts a temperature from Fahrenheit to Celsius. The program should ask the user for a Fahrenheit temperature, perform the mathematical conversion, and display the result.

```
// Ask for Fahrenheit
Console.WriteLine("Enter temperature in Fahrenheit: ");
float fahreinheitInput = float.Parse(Console.ReadLine());

// Calculate
double fahreinheitToCelcius = (5.0 / 9.0) * (fahreinheitInput - 32.0);

// Output
Console.WriteLine($"{fahreinheitInput} degrees Fahrenheit is equal to {fahreinheitToCelcius} degrees Celsius.");
```

Expected Console Flow:
```
Enter temperature in Fahrenheit: 72.5
72.5 degrees Fahrenheit is equal to 22.5 degrees Celsius.
```
