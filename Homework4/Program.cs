// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
/*
Console.WriteLine("Enter three numbers:");
Console.Write("Number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());


int highestNumber;

if (num1 > num2 && num1 > num3)
{
    highestNumber = num1;
}
else if (num2 > num1 && num2 > num3)
{
    highestNumber = num2;
}
else
{
    highestNumber = num3;
}

Console.WriteLine($"The highest number is: {highestNumber}");



    Console.WriteLine("Enter a letter: ");
    char ch = Convert.ToChar(Console.ReadLine());
    {
        switch (ch)
        {
            case 'a':
                Console.WriteLine("The letter is a vowel!");
                break;


            case 'e':
                Console.WriteLine("The letter is a vowel!");
                break;

            case 'i':
                Console.WriteLine("The letter is a vowel!");
                break;

            case 'o':
                Console.WriteLine("The letter is a vowel!");
                break;

            case 'u':
                Console.WriteLine("The letter is a vowel!");
                break;
            default: Console.WriteLine("The letter is a consonant"); break;
        }
        Console.ReadKey();

 }
*/

Console.WriteLine("Wrtie a grade from A to F (capital letters) : ");
char grade = Convert.ToChar(Console.ReadLine());

switch (grade)
{
    case 'A':
        Console.WriteLine("Your grade is 5"); break;
    case 'B':
        Console.WriteLine("Your grade is 4"); break;
    case 'C':
        Console.WriteLine("Your grade is 3"); break;
    case 'D':
        Console.WriteLine("Your grade is 2"); break;
    case 'F':
        Console.WriteLine("Your grade is 1"); break;

    default: Console.WriteLine(" error "); break;
}
Console.ReadLine();





