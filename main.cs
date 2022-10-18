// Created by: Youngwook
// Created on: OCT 2022
//
// This function gets user's home pay

using System;

class Program
{
    public static void Main(string[] args)
    {
        //this function accept user input
        int workedHours;
        int hourlyRate;

        Console.WriteLine("This program gets user's home pay.");
        Console.WriteLine("Please enter your employment information.\n");
        Console.Write("Enter number of hours worked: "); workedHours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter hourly rate: "); hourlyRate = Convert.ToInt32(Console.ReadLine());

        //this function prints the result
        Console.WriteLine("\n\nYour pay will be: " + ((workedHours * hourlyRate) - ((workedHours * hourlyRate) * 0.18)).ToString("0.00") + ". ");
        Console.WriteLine("Your government took: " + ((workedHours * hourlyRate) * 0.18).ToString("0.00") + ". ");
    }
}