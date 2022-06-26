// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


void Adition(int value1, int value2)

{

    Console.WriteLine($" {value1} + {value2} = {value1 + value2} ");
}




void Substraction(int value1, int value2)

{

    Console.WriteLine($" {value1} - {value2} = {value1 - value2} ");
}


void Multiplication(int value1, int value2)

{

    Console.WriteLine($"  {value1} * {value2} = {value1 * value2} ");
}


void Division (int value1, int value2)

{
    if (value1 == 0 ||  value2 == 0)
    {
        Console.WriteLine("you cannot devide by zero");
    }
    else
    {
        Console.WriteLine($"  {value1} / {value2} = {value1 / value2} ");
    }
   
}


void modulus (int value1, int value2)

{

    Console.WriteLine($" {value1} % {value2} is {value1 % value2} ");
}




    Console.WriteLine("Enter NUmber 1");
    int value1 = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Enter NUmber 2");
    int value2 = Convert.ToInt32(Console.ReadLine());






// we need some space here 



//Adition (value1 , value2);
//Multiplication (value1, value2);
//Division (value1, value2); 
//modulus(value1, value2)

Console.WriteLine("Enter 0 to End the programme");

Console.WriteLine("Enter 1 for Addition");

Console.WriteLine("Enter 2 for Substraction");

Console.WriteLine("Enter 3 for Multiplication");

Console.WriteLine("Enter 4 for Division");

Console.WriteLine("Enter 5 for Modulus");



void meny()
{
    bool menu = true;
    while (menu)
    {
      
        string inputchoice = Console.ReadLine();
        switch (inputchoice)
        {
            case "0":
                menu = false;
                break;


            case "1": 
                Adition(value1, value2);
             
                break;


            case "2":
               
                Substraction(value1, value2);
                
                break;

            case "3":
                
                Multiplication(value1, value2);
                
                break;

            case "4":
                
                Division(value1, value2);
                
                break;

            case "5":
                
                modulus(value1, value2);
                ;
                break;


            default:
                Console.WriteLine("calculation not valid");
                break;



        }



    }



}

//we will have a case and break  for user to choose 
meny();

