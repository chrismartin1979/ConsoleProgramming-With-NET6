// See https://aka.ms/new-console-template for more information


//Person person = new Person();
// using ClassesAndObjects;

Person person = new();

string middleName = string.Empty;

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Middle Name: ");
middleName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter Middle Name: ");
// middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full Name is: " + person.getFullName());
}
else
{
    Console.WriteLine("Full Name is: " + person.getFullName(middleName));
}

person.setSalary(salary);

// Console.WriteLine("First Name is: " + person.FirstName);
// Console.WriteLine("Last Name is: " + person.LastName);

Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("Salary is: " + person.getSalary());

// DateUtil dateUtil = new DateUtil();
Console.WriteLine("Year Of Birth is: " + DateUtil.YearOfBirth(person.Age));