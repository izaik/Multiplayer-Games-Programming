Console.Write("Enter the width of your rectangle: ");
int width = int.Parse(Console.ReadLine());
Console.Write("\nEnter the height of your rectangle: ");
int height = int.Parse(Console.ReadLine());

int perimeter = width * 2 +  height * 2;
int area = width * height;

Console.WriteLine("Perimeter is: " + perimeter + "\nArea is: " + area);