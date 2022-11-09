// Created by: Youngwook
// Created on: OCT 2022
//
// This function gets user's home pay

using System;

class Program
{
    public static void Main(string[] args)
    {
        double TAXRATE;
        TAXRATE = 0.18;

        //this function accept user input
        double workedHours;
        double hourlyRate;
        double homePay;
        double governmentTook;

        Console.WriteLine("This program gets user's home pay.");
        Console.WriteLine("Please enter your employment information.\n");
        Console.Write("Enter number of hours worked: "); workedHours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter hourly rate: "); hourlyRate = Convert.ToInt32(Console.ReadLine());

        governmentTook = (workedHours * hourlyRate) * TAXRATE;
        homePay = (workedHours * hourlyRate) - governmentTook;

        //this function prints the result
        Console.WriteLine("\nYour pay will be: " + homePay.ToString("0.00") + " $");
        Console.WriteLine("Your government took: " + governmentTook.ToString("0.00") + " $");
    }
}
