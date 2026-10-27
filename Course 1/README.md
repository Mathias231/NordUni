# Course 1 showcase
## Task 1: The Digital ID Card 

> Task: Write a program that asks the user for their personal details and then prints a formatted "ID Card" to the console. You must use the following data types: `string` (name), `int` (age), `char` (initial), and `float` or `double` (height in meters.

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

What I would do differently after delivery:
```

```

## Task 2: Temperature Converter 
> Task: Create a program that converts a temperature from Fahrenheit to Celsius. The program should ask the user for a Fahrenheit temperature, perform the mathematical conversion, and display the result.

Expected Console Flow:
```
Enter temperature in Fahrenheit: 72.5
72.5 degrees Fahrenheit is equal to 22.5 degrees Celsius.
```

Here is what I delivered:
```
// Ask for Fahrenheit
Console.WriteLine("Enter temperature in Fahrenheit: ");
float fahreinheitInput = float.Parse(Console.ReadLine());

// Calculate
double fahreinheitToCelcius = (5.0 / 9.0) * (fahreinheitInput - 32.0);

// Output
Console.WriteLine($"{fahreinheitInput} degrees Fahrenheit is equal to {fahreinheitToCelcius} degrees Celsius.");
```

What I would do differently after delivery:
```

```

## Task 3: The Leap Year Checker
> Task: Write a program that asks the user for a year and determines if it is a leap year. The program should store the final result in a `boolean` variable before printing it.

> Leap Year Rules:
> - If the year is evenly divisible by 4, go to step 2. Otherwise, it is NOT a leap year.
> - If the year is evenly divisible by 100, go to step 3. Otherwise, it IS a leap year.
> - If the year is evenly divisible by 400, it IS a leap year. Otherwise, it is NOT a leap year.

Expected Console Flow:
```
Enter a year: 2024
Result: 2024 is a leap year.
```

Here is what I delivered:
```

```



What I would do differently after delivery:
```

```

## Task 4: Multiplication Table Generator
> Task:Ask the user to input a whole number between 1 and 12. Use 10 lines of code to generate and print the multiplication table for that specific number from 1 to 10.

Expected Console Flow:
```
Enter a number for the multiplication table: 7

--- Multiplication Table for 7 ---
7 x 1 = 7
7 x 2 = 14
...
7 x 10 = 70
```

Here is what I delivered:
```

```

What I would do differently after delivery:
```

```
