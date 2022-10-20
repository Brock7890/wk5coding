Console.WriteLine("Welcome to method testing.");
int radius;
double area;

void circleAreaCalculator()
{
    Console.Write("Enter the radius of a circle: ");
    radius = Convert.ToInt32(Console.ReadLine());
    area = Math.PI * (radius * radius);
    Console.WriteLine($"The area of this circle is {area.ToString("0.0000")}");
}
circleAreaCalculator();
Console.ReadKey();