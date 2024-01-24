string typeFigure = Console.ReadLine();
if (typeFigure == "square")
{ double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:F2}");
}
else if (typeFigure == "rectangle")
{
    double width = double.Parse(Console.ReadLine());    
    double lenght = double.Parse(Console.ReadLine());

    double area = width * lenght;
    Console.WriteLine($"{area:F2}");
}
else if (typeFigure == "circle")
{
    double radius = double.Parse(Console.ReadLine());   
    double area = radius * radius * Math.PI;
    Console.WriteLine($"{area:F2}");
}
