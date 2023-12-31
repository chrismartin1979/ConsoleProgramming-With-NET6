﻿// See https://aka.ms/new-console-template for more information
string firstName = "Chris";
string lastName = "Martin";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + firstName + " " + lastName);
Console.WriteLine($"My full name is {lastName}, {firstName}");
Console.WriteLine("My full name is {0}, {1}", firstName, lastName);

// String length
int length = firstName.Length;
Console.WriteLine($"Your first name is {length} letters long");

// Replace string parts
string newName = firstName.Replace('C', 'K');
Console.WriteLine($"Your new name is {newName}");

string newName1 = firstName.Replace('h', ' ');
Console.WriteLine($"Your new name is {newName1}");

// Append to other string variable
string fullName = firstName + " "  + lastName;
Console.WriteLine($"Your full name is {fullName}");

// Split String
string[] splitName = fullName.Split('r');
for (int i = 0;  i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// Compare Strings
string nullString = null;
string emptyString = "";  // string.Empty;
string whitespaceString = " "; // string.WhiteSpace;

if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if(firstName == lastName)
{
    Console.WriteLine("Names are equal");
}

if (firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

// Convert to String
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 1543456.ToString();

fullName.ToUpper();
fullName.ToLower();

