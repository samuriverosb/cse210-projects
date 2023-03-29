using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("La Selva 29", "Villa Alemana", "Valparaiso", "Chile");
        Address address2 = new Address("Eleuterio Ramirez", "Quilpué", "Valparaiso", "Chile");
        Address address3 = new Address("Barrio Los Robles 171", "Pilar", "Buenos Aires", "Argentina");
        Lecture lecture = new Lecture("Samu Ted Talk", "Samu is giving a new Ted Talk related to Black Holes", "03/31/2023", "15:30", address1, "Samu Riveros", 60);
        Reception reception = new Reception("Andi Wedding", "Let's all welcome Andi to her new Married Life", "05/13/2023", "21:30", address3, "samuel.riverosb@gmail.com");
        Outdoor outdoor = new Outdoor("Folklore Expo", "Folklore exposition showing all folkloric elements present on Latin American Countries", "09/18/2023", "13:00", address2, "Sunny");

        Console.Clear();
        Console.WriteLine("Standard Details: ");
        lecture.StandardDetails();
        reception.StandardDetails();
        outdoor.StandardDetails();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        lecture.FullDetails();
        reception.FullDetails();
        outdoor.FullDetails();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Short Details: ");
        lecture.ShortDetails();
        reception.ShortDetails();
        outdoor.ShortDetails();
    }
}