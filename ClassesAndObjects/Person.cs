﻿// See https://aka.ms/new-console-template for more information
// primitive datatypes
// int, string, char, bool

// Object Oriented Programming - Creating your own datatype
// class - blueprint of what the object is going to be

// Single Responsibility Principle

public class Person
{
    // Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Fields when private
    private double _salary { get; set; } 

    public void setSalary(double salary)
    {
        _salary = salary;
    }

    public double getSalary()
    {
        return _salary;
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullName(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
}