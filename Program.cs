Console.WriteLine("Welcome to method testing.");
int radius;
double area;
double circum;
Console.Write("Enter the radius of a circle: ");
radius = Convert.ToInt32(Console.ReadLine());

void circleAreaCalc()
{
    area = Math.PI * (radius * radius);
    Console.WriteLine($"The area of this circle is {area.ToString("0.0000")} units squared");
}
void circleCircumferenceCalc()
{
    circum = Math.PI * (2 * radius);
    Console.WriteLine($"The diameter of this circle is {circum.ToString("0.0000")} units");
}
circleAreaCalc();
circleCircumferenceCalc();
Console.ReadKey();