using System;
 
class CollegeFootballIntro
{
    static void Main(string[] args)
    {
        try
        {
            // Get the enjoyment level from the user
            string enjoymentLevel = GetEnjoymentLevel();
            Console.WriteLine("You selected: " + enjoymentLevel);  // Debugging print
 
            // Get the recommended stadium based on the enjoyment level
            string stadium = GetStadiumRecommendation(enjoymentLevel);
            Console.WriteLine("Recommended stadium: " + stadium);  // Debugging print
 
            // Get the recommended game for the chosen stadium
            string game = GetGameRecommendation(stadium);
            Console.WriteLine("Recommended game: " + game);  // Debugging print
 
            // Display the stadium details to the user
            DisplayStadiumDetails(stadium, game);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
 
    // Method to prompt the user for the enjoyment level and return the value
    static string GetEnjoymentLevel()
    {
        Console.WriteLine("Enter your preferred level of enjoyment (Boring, Average, Fun, Epic): ");
        string enjoymentLevel = Console.ReadLine();
 
        // Validate the input
        while (string.IsNullOrEmpty(enjoymentLevel) || 
              (enjoymentLevel.ToLower() != "boring" && enjoymentLevel.ToLower() != "average" && 
               enjoymentLevel.ToLower() != "fun" && enjoymentLevel.ToLower() != "epic"))
        {
            Console.WriteLine("Invalid input. Please enter (Boring, Average, Fun, Epic): ");
            enjoymentLevel = Console.ReadLine();
        }
 
        return enjoymentLevel;
    }
 
    // Method to determine the best stadium based on the enjoyment level
    static string GetStadiumRecommendation(string enjoymentLevel)
    {
        switch (enjoymentLevel.ToLower())
        {
            case "boring":
                return "Neyland Stadium";
            case "average":
                return "Jordan-Hare Stadium";
            case "fun":
                return "Tiger Stadium";
            case "epic":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                return "Unknown Stadium";  // This shouldn't occur due to validation
        }
    }
 
    // Method to determine the best game to attend based on the stadium
    static string GetGameRecommendation(string stadium)
    {
        switch (stadium)
        {
            case "Neyland Stadium":
                return "vs Kent State";
            case "Jordan-Hare Stadium":
                return "vs Kentucky";
            case "Tiger Stadium":
                return "vs Alabama";
            case "Saban Field at Bryant-Denny Stadium":
                return "vs Auburn";
            default:
                return "Unknown Game";
        }
    }
 
    // Method to return a message detailing the college stadium and the best game to attend
    static void DisplayStadiumDetails(string stadium, string game)
    {
        Console.WriteLine($"Recommended Stadium: {stadium}");
        Console.WriteLine($"Recommended Game: {game}");
    }
}