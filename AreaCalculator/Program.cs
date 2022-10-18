
using AreaCalculator;
using AreaCalculator.Utils;


Shape selectedShape;
while (true)
{
    Console.WriteLine("Enter your choise \n");
    foreach (Shape shape in Enum.GetValues(typeof(Shape)))
    {
        Console.WriteLine((int)shape + " For " + Enum.GetName(shape.GetType(), shape));
    }

    Console.WriteLine("Enter 100 to exit \n");

    int selection;
    if (int.TryParse(Console.ReadLine(), out selection) && Enum.IsDefined(typeof(Shape), selection) || selection == 100)
    {
        if (selection == 100)
        { 
            Environment.Exit(0);
        }
        double radius = 0, length = 0, @base = 0, height = 0;

        selectedShape = (Shape)selection;

        if (selectedShape == Shape.Circle)
        {
            Console.WriteLine("Enter radius :");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        else if (selectedShape == Shape.Square)
        {
            Console.WriteLine("Enter length : ");
            length = Convert.ToDouble(Console.ReadLine());
        }
        else if (selectedShape == Shape.Triangle)
        {
            Console.WriteLine("Enter base :");
            @base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height : ");
            height = Convert.ToDouble(Console.ReadLine());
        }
                
        Calculator.CalculateAndShowAreaOfShape(selectedShape, radius, length, @base, height);
    }
    else
    {
        Console.WriteLine("Not a Valid Shape, Please try again");
    }
}