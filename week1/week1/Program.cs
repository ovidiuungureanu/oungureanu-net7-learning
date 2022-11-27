//Type Name = 100
//Type Name = Expression
int number = 100;  
Console.WriteLine(number);

//int - nr fara virgula
//byte - 0 - 255
//long - 99999999
//float - nr. cu virgula     -3.4000 3.4000
//double - nr. cu virgula     -3.40000000000000000000000000000000
// char - caracter
// bool - True (1) sau False (0)
// string - siruri de caractere
//DateTime - data

float number2 = 100.5f;
char character = 'a';
string myName = "Ovidiu";

Console.WriteLine(myName);

int FirstNumber = 5;
int SecondNumber = 8;
int sum = number3 + number4;

// char -> int -> long -> float -> double

//Console.ReadLine() -> citi input de la utilizator

Console.WriteLine("care este numele tau?");
string name = Console.ReadLine();
Console.WriteLine("Salut" + name);

Console.WriteLine("care este varsta ta?");
string input = Console.ReadLine();
int age = Convert.ToInt32(input);
Console.WriteLine("Varsta introdusa este" + age);

// + Addittion
// - Substraction  
// * Multiplication
// / Division
// ++ Increment
// -- Decrement
// % Modulus

int sum = 5 + 10;
double FirstNumber = 10;
doble SecondNumber = 3;
double division = 10.0 / 3.0;
Console.WriteLine(division);

int number = 5;
int secondNumber = --number;
Console.WriteLine(secondNumber);

int result = 10 % 3; //restul impartirii lui 10 la 3
Console.WriteLine(result);

//int x = 4;
//x = x + 5;
//// x =  + 5;
//x += 5; // echivalent cu linia 61

// == Equal to
Console.WriteLine(5 == 5);
Console.WriteLine(5 == 6);
// != Not Equal
Console.WriteLine(5 != 5);
Console.WriteLine(5 != 6);
// > Greater than
Console.WriteLine(5 > 4);
// < Less than
// >= Greater or equal to
// <= Less or equal to

// && logical and
// II logical or
// ! logical not
Console.WriteLine(6 > 5 && 3 > 2); // True && True => True

var CONDITIE = true;
if (CONDITIE)
{
    //Codul de aici se executa daca conditia este adevarata
}

Console.WriteLine("Introdu varsta");
int age = Convert.ToInt32(Console.ReadLine());
int childAge = Convert.ToInt32(Console.ReadLine());
if (age < 90 && childAge > 25)
{
    Console.WriteLine("Te primim in grup");
}
else
{
    // Codul de aici se executa cand conditia este falsa
    Console.WriteLine("Nu te primim in grup");
}

if (age < 90 && childAge > 25)
{
    Console.WriteLine("Te primim in grup");
}
else if (age > 90 && age < 100)
{
    // Codul de aici se executa cand conditia din al 2-lea if este adevarata
    Console.WriteLine("Poti incerca la anul");
}
else
{
    // Codul de aici se executa cand conditia din al 2-lea if este falsa
}

int day = 3;
if (day == 1)
{
    Console.WriteLine("Luni");
}
else if (day == 2)
{
    Console.WriteLine("Marti");
}
else
{
    Console.WriteLine("Ziua nu exista");
}

switch (day)
{
    case 1:
        Console.WriteLine("Luni");
        break;
        case 2:
        Console.WriteLine("Marti");
        break ;
        default:
        Console.WriteLine("Ziua nu exista");
        break;
}











