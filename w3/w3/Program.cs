//int i;
//for (i=123; i<=234; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine(i + "FizzBuzz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine(i + "Buzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine(i + "Fizz");
//    }
//    else
//        Console.WriteLine(i);
//}

//int n = 1;
//while (n < 6) //n <= 5
//{
//    Console.WriteLine("Current value of n is" + n);
//    //Console.WriteLine($"Current value of n is {n}");
//    //Console.WriteLine("Current value of n is {0}, {1}", n, 234);
//    n++;
//}

//n = 567;
//while (n > 550)  // n+551
//{
//    Console.WriteLine(n);
//    n--;
//}


//int n = -100;

//List<int> l1 = new List<int>();

//while (n <= 100)
//{
//    if (n % 7 == 0) ;
//    {
//        l1.Add(n);
//        Console.WriteLine(n);
//    }
//    n++;
//}



//List<string> l2 = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
//int x = 0;

//while (x < 6)
//{
//    Console.WriteLine(l2[x]);
//    x++;
//}



//List<string> l3 = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
//int y = l3.Count - 1;
//int z = y - 3;

//while (y >z)
//{
//    Console.WriteLine(l3[y]);
//    y--;
//}

//Console.WriteLine();
//int x1 = l3.Count - 1;

//    while( x1>= l3.Count - 3)
//{
//    Console.WriteLine(l3[x1]);
//    x1--;
//}

//Console.WriteLine();
//Console.WriteLine("----DoWhile------");

//int x = 0;
//do
//{
//    Console.WriteLine(x);
//    x++;
//} while (x < 5);

//Console.WriteLine();
//x = 120;
//do
//{
//    Console.WriteLine(x);
//    x--;
//}while (x > 115);

//Console.WriteLine();
//x = 120;
//do
//{
//    Console.WriteLine(x);
//    x--;
//    Console.WriteLine(x);
//} while (x < 115);
//Console.WriteLine("after while" + x);


//int z = 56;

//do
//{
//    if (z % 24 == 0)
//    {
//        Console.WriteLine(z);
//    }
//    z++;
//} while (z < 987);

//int number1;
//do
//{
//    Console.WriteLine("number");
//    string number = Console.ReadLine();
//    number1 = Convert.ToInt32(number);



//} while ( number1 !=0 );



using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

//Console.WriteLine();
//Console.WriteLine("---------Continue--------");

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 5)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}


//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("before" + i);
//    if (i == 5)
//    {
//        continue;
//    }
//    Console.WriteLine("after" + i);
//}

//int n = 0;
//while ( n <= 100)
//{
//    Console.WriteLine("before" + n);
//    if (n % 2 ==0 || n%5 == 0)
//    {
//        n++;
//        continue;
//    }

//    n++;    
//    Console.WriteLine("after" + n);
//}

//Console.WriteLine();
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 5)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}


//int x = -1;

//do
//{
//        Console.WriteLine(x);
//    if (x % 21 == 0)
//    {
//        break;
//    }
//    x--;

//}while (x >= -123);

//Console.WriteLine("before");
//for (int i = 0; i <= 5; i++)
//{
//    int number = i * 5 + 34 - 2;
//    Console.WriteLine(number);
//}
//Console.WriteLine("after");

//Console.WriteLine();
//int[,] myArray = new int[3, 2]
//{
//    {2, 6},
//    {9, 3},
//    {7, 5}
//};

//Console.WriteLine(myArray[0, 0]);
//Console.WriteLine(myArray[2, 0]);

//var rows = myArray.GetLength(0);
//var cols = myArray.GetLength(1);

//Console.WriteLine("rows = " + rows + " cols = " + cols);

//for(int i = 0; i < rows; i++)
//{
//    for(int j = 0; j < cols; j++)
//    {
//        Console.Write(myArray[i, j] + " ");
//    }
//    Console.WriteLine();
//}


//Console.WriteLine();
//List<int> l1 = new List<int> { 4, 8, 5, 3};
//List<int> l2 = new List<int> { 40, 80, 50, 30, 100 };

//foreach(int i in l1)
//{
//    foreach(int j in l2)
//    {
//        Console.WriteLine(i + j);
//    }
//}


// MIN MAX
// Print Min value and max of an array
// Do not use array.min() or Max

//Console.WriteLine();
//int[] myArray1 = new int[] { -1, 2, 3, 8, -12, 56};

//Console.WriteLine(myArray1.Min());
//Console.WriteLine(myArray1.Max());
//Console.WriteLine();

//int min = myArray1[0];
//int max = myArray1[0];

//foreach(int i in myArray1)
//{
//    if(i < min)
//    {
//        min = i;
//    }
//    if(i > max)
//    {
//        max = i;
//    }
//}
//Console.WriteLine("min = " + min + " max = " + max);

// Prime number
// write an algorithm to check if a nr is prime or not (it only divides by 1 and itself)
// Print "the number is prime" is so or "the number is not prime" otherwise
// Prime numbers: 13, 23
// Not prime numbers: 12, 24, 15

//Console.WriteLine();
//int numberToBeChecked = 13;
//bool isPrime = true;

//for(int i = 2; i < numberToBeChecked; i++)
//{
//    if(numberToBeChecked % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}

//if (isPrime)
//{
//    Console.WriteLine("the number is prime");
//}
//else
//{
//    Console.WriteLine("the number is not prime");
//}

// Search
// Given an unsorted array which might have a number in the majority (a number appears more than 50 % in the array),
// find and print the first majority number if it exists.

//Console.WriteLine();
//myArray1 = new int[] { 1, 2, 1, 3, 1 };

//for(int i = 0; i < myArray1.Length; i++)
//{
//    int count = 1;

//    for(int j = i + 1; j < myArray1.Length; j++)
//    {
//        if (myArray1[i] == myArray1[j])
//        {
//            count++;
//        }
//    }

//    if(count > myArray1.Length / 2)
//    {
//        Console.WriteLine("number = " + myArray1[i] + " count = " + count);
//    }
//}

// Bubble sort

//Console.WriteLine();
//int[] array = new int[] { 1, 6, 4, 5, 2, 0, -1 }; // -1, 0, 1, 2, 4, 5, 6

//for(int i = 0; i < array.Length; i++)
//{
//    for(int j = i + 1; j < array.Length; j++)
//    {
//        if(array[i] > array[j])
//        {
//            int aux = array[i];
//            array[i] = array[j];
//            array[j] = aux;
//        }
//    }
//}

//Console.WriteLine("sorted array:");
//for(int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i] + " ");
//}



//Console.WriteLine();
//int a = 3;
//int b = 5;

//// a = 5, b = 3

//int y = a;
//a = b;
//b = y;

//Console.WriteLine("a=" + a + ", b=" + b);


// Palindrome
// write an algorithm to check if a number is a palindrome or not (it is the same read from both ends).
// Print "the number is palindrome" if so or "the number is not palindrome" otherwise
// 2002, 1993, 121, 909, 22

//Console.WriteLine();
//int nr = 121;
//int rest = 0, reverse = 0;
//int temporary = nr;

//while (temporary > 0)
//{
//    rest = temporary % 10;  // store the last digit of the number
//    temporary /= 10;   // temporary = temporary / 10; get rid og the last digit of the number
//    reverse = (reverse * 10) + rest;
//}

//if( nr == reverse)
//{
//    Console.WriteLine("da");
//}
//else
//{
//    Console.WriteLine("nu");
//}





















