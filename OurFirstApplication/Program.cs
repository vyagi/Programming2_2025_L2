//Task 8
Console.WriteLine("Enter side a");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter side b");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter side c");
double c = double.Parse(Console.ReadLine());

double perimeter = a + b + c;

double s = perimeter / 2;

double area = Math.Sqrt(s * (s-a)*(s-b)*(s-c));

Console.WriteLine($"The area is {area} and perimeter is" +
    $"the perimeter is {perimeter}");


//Task 5
//Console.WriteLine("Enter the radius");

//double radius = double.Parse(Console.ReadLine());

//double area = Math.PI * radius * radius;

//Console.WriteLine($"The area is {area}");

//Task 4
//Console.WriteLine("What is your name?");

//string name = Console.ReadLine();

//Console.WriteLine($"Hello {name}");

//Task 3
//string name = "Marcin";
//d recommended
//Console.WriteLine($"Hello {name}");

//c should be avoided
//Console.WriteLine(string.Format("Hello {0}", name));

//b not recommended
//Console.WriteLine("Hello " + name);

//a
//Console.Write("Hello ");
//Console.Write(name);

//Task 2
//string name = "Marcin";
//Console.WriteLine(name);

//Task 1
//Console.WriteLine("Hello");