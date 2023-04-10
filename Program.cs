// Room Calculator 
Console.WriteLine("Welcome to the Room Dimension Calculator!");
Console.WriteLine("Enter room Length (ft):");
string length = Console.ReadLine();
decimal l = decimal.Parse(length);

Console.WriteLine("Enter room Width (ft):");
string width = Console.ReadLine();
decimal w = decimal.Parse(width);

decimal area = l * w;
Console.WriteLine($"The Area is {area} sq ft.");

decimal per = (l + w) * 2;
Console.WriteLine($"The Perimeter is {per} ft.");

if ( area <= 250)
{
    Console.WriteLine("This is a Small room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a Medium sized room.");
}
else if (area >= 650)
{
    Console.WriteLine("This is a Large room.");
}
Console.WriteLine("Enter the height of the room (ft):");
string height = Console.ReadLine();
decimal h = decimal.Parse(height);

decimal v = l * w * h;
Console.WriteLine($"The volume of the room is {v} ft cubed.");

decimal sfArea = 2 * ((w*l) + (h*l) + (h*w));
Console.WriteLine($"The Surface Area of the room is {sfArea} sq ft.");

Console.WriteLine("Thank for using the Room Calculator!"); 