// See https://aka.ms/new-console-template for more information


// For Loop (Counter Controlled Loop)
for(int i = 0; i < 5; i++)
{
    Console.WriteLine("I am in a loop");
    Console.WriteLine($"Counter value: {i}");
}

Console.WriteLine();
Console.WriteLine("FOR LOOP FINISHED");

// While Loop (Condition Controlled Loop - Pre Check)
int n = 0;
while(n < 5)
{
    Console.WriteLine("Input a number:  ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}: ");
}

Console.WriteLine();
Console.WriteLine("WHILE LOOP FINISHED");

// Do...While Loop (Condition Controlled Loop - Post Check)

int rep = 0;
do
{
    Console.WriteLine("Input a number:  ");
    rep = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {rep}: ");
}
while (rep < 5);

Console.WriteLine();
Console.WriteLine("DO...WHILE LOOP FINISHED");

// For Each Loop - Honorable Mention
