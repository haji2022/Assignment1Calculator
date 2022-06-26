// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculator");


Console.WriteLine("enter a value");
string value1str = Console.ReadLine();

Console.WriteLine("enter a value");
string value2str = Console.ReadLine();


// convert string to Numbers

double value1 = Convert.ToDouble(value1str);
double value2 = Convert.ToDouble(value1str);


double add = value1 + value2;
Console.WriteLine($"{value1} + {value2} =  :{value1 + value2}");
// if you dont put the dollar sign the INTERPOLATION{} wont  work
double sub = value1 + value2;
Console.WriteLine($"{value1} - {value2} = :{value1 - value2}");
double mult = value1 + value2;
Console.WriteLine($" {value1} * {value2} = :{value1 * value2}");
double divide = value1 + value2;
Console.WriteLine($" {value1} / {value2} = :{value1 / value2}");
double modulus = value1 + value2;
Console.WriteLine($" {value1} % {value2} = :{value1 % value2}");




/*Console.WriteLine("enter a word");
string entreword = Console.ReadLine();

Console.WriteLine($"you entered : {entreword}");*/