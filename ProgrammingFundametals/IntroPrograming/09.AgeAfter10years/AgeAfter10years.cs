using System;

class AgeAfter10years
{
    static void Main()
    {
        Console.WriteLine("Enter birthday date:");
        DateTime birthdayDate = DateTime.Parse(Console.ReadLine());
        long result = DateTime.Today.Subtract(birthdayDate).Ticks;
        Console.WriteLine("You are {0} years old.", new DateTime(result).Year - 1);
        Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(result).AddYears(10).Year - 1);
    }
}