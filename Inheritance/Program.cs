// See https://aka.ms/new-console-template for more information
using System;


Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());


// var cube = new Cube() { Width = width, Length = length, Height = height };
var cube = new Cube(width, height, length);

var triangle = new Triangle();
var triangle2 = new Triangle() { Length = length, Height = height, Hypotenuse = 10 };
var triangle1 = new Triangle(10);
var triangle3 = new Triangle(10, height, length);

var rectangle = new Rectangle() { Length = length, Width = width };

// cube.Length = length;
// cube.Width = width;
// cube.Height = height;

// triangle.Length = length;
// triangle.Height = height;

// rectangle.Length = length;
// rectangle.Width = width;

Console.WriteLine("Cube Area Is: " + cube.GetArea());
Console.WriteLine("Cube Volume Is: " + cube.GetVolume());

Console.WriteLine("Triangle Area Is: " + triangle.GetArea());
Console.WriteLine("Triangle2 Area Is: " + triangle2.GetArea());
Console.WriteLine("Triangle1 Area Is: " + triangle1.GetArea());
Console.WriteLine("Triangle3 Area Is: " + triangle3.GetArea());

Console.WriteLine("Rectangle Area Is: " + rectangle.GetArea());
