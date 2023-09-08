// See https://aka.ms/new-console-template for more information

class Triangle : Shape, IShape
{
    public Triangle()
    {
            
    }

    public Triangle(int hyp)
    {
        Hypotenuse = hyp;       
    }

    public Triangle(int hyp, int height, int length)
    {
        Hypotenuse = hyp;
        Height = height;
        Length = length;
    }
    public double Hypotenuse { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}