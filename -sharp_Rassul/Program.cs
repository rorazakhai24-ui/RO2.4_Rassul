using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("1 – Online Store Order\n2 – Cinema Ticket\n3 – Gym Membership");
        Console.Write("Your Choice: 2\n\n");

        Console.Write("Movie Title: ");
        string movieTitle = Console.ReadLine();

        Console.Write("Number of Tickets: ");
        int ticketsCount = int.Parse(Console.ReadLine());

        Console.Write("Price per Ticket: ");
        decimal ticketPrice = decimal.Parse(Console.ReadLine());

        Console.Write("Duration in hours: ");
        double movieHours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Screen Number: ");
        int screenNumber = int.Parse(Console.ReadLine());

        Console.Write("First Letter of Row: ");
        char rowLetter = char.Parse(Console.ReadLine());

        Console.Write("Is 3D Movie (true/false): ");
        bool is3DMovie = bool.Parse(Console.ReadLine());

        decimal totalCost = ticketsCount * ticketPrice;
        decimal costPerHour = totalCost / (decimal)movieHours;

        Console.WriteLine("\nMovie: " + movieTitle + " | Tickets: " + ticketsCount + " | Price: " + ticketPrice);
        Console.WriteLine("Total Cost: " + totalCost + " | Cost per Hour: " + costPerHour);

        Console.WriteLine("\nTypes: " + ticketsCount.GetType() + ", " + movieHours.GetType() + ", " + is3DMovie.GetType());
    }
}