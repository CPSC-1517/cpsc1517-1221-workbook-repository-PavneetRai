﻿// See https://aka.ms/new-console-template for more information
using NhlSystem;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.Json;


//Console.WriteLine("Hello, World!");

///*
// * Test plan for person 
// * 
// * test case                                Test Data                                   Expected Result/Behaviour
// * ---------                                ---------                                   ------------------------- 
// * Valid FullName                           FullName = Connor McDavid                    FullName = Connor McDavid 
// * 
// * Null FullName                            FullName = null                              ArguementNullException 
// * 
// * Empty FullName                           FullName = ""                                ArguementNullException
// * 
// * whitespace fullname                      FullName = "  "                              ArguementNullException
// * 
// * Fullname less than 3 characters          FullName = "AB"                              ArguementException 
// * 
// */

//// Test Case 1:  Valid FullName 

//var validPerson = new Person("Connor McDavid");
//Console.WriteLine(validPerson.FullName); // The value should be Connor McDavid 

////Test Case 2: Null FullName
//try
//{
//    var nullPerson = new Person(null);
//    Console.WriteLine("Null Test Case failed");
//}
//catch(ArgumentNullException ex)
//{
//    Console.WriteLine(ex.ParamName); //The output should be "Full Name is required" 
//}
////Test Case 3: Empty FullName 
//try
//{
//    var emptyPerson = new Person("");
//    Console.WriteLine("Empty Test Case failed");
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine(ex.ParamName); //The output should be "Full Name is required" 
//}
////Test Case 4: whitespace 
//try
//{
//    var whitespacePerson = new Person("    ");
//    Console.WriteLine("Whitespace Test Case failed");
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine(ex.ParamName); //The output should be "Full Name is required" 
//}
////Test case 5: Minimum Lenght fullname 
//try
//{
//    var invalidlengthPerson = new Person("AB");
//    Console.WriteLine("Fullname length Test Case failed");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine(ex.Message); //The output should be "Full Name is required" 
//}

////test creating a new team 
////Create a new coach for the team 
////create a start date 
//DateTime startDate = DateTime.Parse("2021-09-02");
//Coach oilersCoach = new Coach("Jay Woodcroft", startDate);

////Create a new Team 
//Team oilersTeam = new Team("Edmonton Oilers", oilersCoach);

////Ad 3 players to the team 
//Player player1 = new Player("Connor McDavid", Position.C, 97);
//Player player2 = new Player("Evander Kane", Position.LW, 91);
//Player player3 = new Player("Leeon Draissaitl", Position.C, 29);

//oilersTeam.AddPlayer(player1);
//oilersTeam.AddPlayer(player2);
//oilersTeam.AddPlayer(player3);

//// Assign Goals and Assists to each player
//player1.Goals = 44;
//player1.Assists = 79;
//player2.Goals = 22;
//player2.Assists = 17;
//player3.Goals = 55;
//player3.Assists = 55;

//// Check that the team has 3 players
//Console.WriteLine($"Players in team is {oilersTeam.Players.Count}");
//// Print each player in the team
//foreach (Player currentPlayer in oilersTeam.Players)
//{
//    Console.WriteLine(currentPlayer);
//}
//// Check the TotalPlayerPoints. Should be (44+79+22+17+55+55) = 272
//Console.WriteLine($"Total player points is {oilersTeam.TotalPlayerPoints}");

//CreatePlayersCsvFile();

//static void CreatePlayersCsvFile()
//{
//    DateTime startDate = DateTime.Parse("2021-09-02");
//    Coach oilersCoach = new Coach("Jay Woodcroft", startDate);


//    Team oilersTeam = new Team("Edmonton Oilers", oilersCoach);

//    Player player1 = new Player("Connor McDavid", Position.C, 97);
//    Player player2 = new Player("Evander Kane", Position.LW, 91);
//    Player player3 = new Player("Leeon Draissaitl", Position.C, 29);
//    oilersTeam.AddPlayer(player1);
//    oilersTeam.AddPlayer(player2);
//    oilersTeam.AddPlayer(player3);

//    const string PlayerCsvFile = "../../../Players.csv";
//    File.WriteAllLines(PlayerCsvFile,
//        oilersTeam.Players.Select(currentPlayer => currentPlayer.ToString()).ToList());

//}
CreateTeamJsonFile();

static void CreateTeamJsonFile()
{
    DateTime startDate = DateTime.Parse("2021-09-02");
    Coach oilersCoach = new Coach("Jay Woodcroft", startDate);


    Team oilersTeam = new Team("Edmonton Oilers", oilersCoach);

    Player player1 = new Player("Connor McDavid", Position.C, 97);
    Player player2 = new Player("Evander Kane", Position.LW, 91);
    Player player3 = new Player("Leeon Dhaissaitl", Position.C, 29);
    oilersTeam.AddPlayer(player1);
    oilersTeam.AddPlayer(player2);
    oilersTeam.AddPlayer(player3);

    const string TeamJsonFile = "../../../Team.json";
    
    JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true,
        IncludeFields = true
    };
    string jsonString = JsonSerializer.Serialize<Team>(oilersTeam, options);
    File.WriteAllText(TeamJsonFile, jsonString);
}

