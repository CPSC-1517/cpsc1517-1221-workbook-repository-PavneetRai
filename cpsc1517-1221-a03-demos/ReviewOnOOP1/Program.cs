// See https://aka.ms/new-console-template for more information
using ReviewOnOOP1;

Console.WriteLine("Helloo, World!");

var senators = new NhlTeam(NhlConference.Eastern, NhlDivision.Alantic, "senators", "ottawa");
senators.Gamesplayed = 82;
senators.Wins = 33;
senators.Lossess = 42;
senators.Overtimelosses = 7;
//print the points 

Console.WriteLine(senators);
Console.WriteLine($"Points = {senators.Points}");
