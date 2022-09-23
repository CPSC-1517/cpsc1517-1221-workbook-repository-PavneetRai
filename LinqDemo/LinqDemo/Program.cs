// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LinqDemo; // for videogame
using System.Collections.Generic;
using static System.Console; //all you use access all static methods in Console class with Console prefix.
                             //basically dont need to write "Console." ex. WriteLine(example); no need for Console.WriteLine(example);

//Create a new List of VideoGames with sample data 
var games = new List<VideoGame>
{
    new VideoGame("Diablo III","Nintendo",34.99,1),
    new VideoGame("NBA 2K20 (PS4)","PlayStation",49.99,2),
    new VideoGame("NBA 2K20 (Switch)","Nintendo",49.99,3),
    new VideoGame("NBA 2K20 (Xbox one)","Xbox",49.99,4),
    new VideoGame("Forza Horizon 4","Xbox",39.99,5),
    new VideoGame("Final Fantasy X","Nintendo",34.99,6),
    new VideoGame("The Outer Worlds","PlayStation",49.99,7),
    new VideoGame("Kingdom Hearts 3","PlayStation",19.99,8),
    new VideoGame("Overwatch Legendary Edition","Nintendo",34.99,9),
    new VideoGame("WWE 2K20","PlayStation",19.99,10),
    new VideoGame("Kingdom Hearts 3","Xbox",19.99,11),
    new VideoGame("Dragon Quest Builders 2","PlayStation",29.99,12),
};
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Print all games to the screen  using foreach statement");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Print all games to the screen  using foreach statement
foreach (VideoGame currentgame in games)
{
    WriteLine(currentgame);
}
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Print all games to the screen for statement
WriteLine("Print all games to the screen for statement");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
for (int index = 0; index < games.Count; index++)
{
    var currentgame = games[index];
    WriteLine(currentgame);
}
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Print all games to the screen using the LinQ ForEach extension function
WriteLine("Print all games to the screen using the LinQ ForEach extension function");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//this reduced foreach to a simple statement 
//this is a lambda expression
games.ForEach(currentgame => WriteLine(currentgame));
//Can be written this way as well 
//games.ForEach(currentgame =>
//{
//    WriteLine(currentgame);
//});
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Print all Nintendo Games using the LinQ Where extension to filter elements");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Print all Nintendo Games using the LinQ Where extension to filter elements 
games.Where(currentgame => currentgame.Platform == "Nintendo")
    .ToList()
    .ForEach(currentgame => WriteLine(currentgame));
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Print all Nintendo games using LinQ Query Syntax");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Print all Nintendo games using LinQ Query Syntax
//this is better for queries 
var nintendoGameQuery = from currentgame in games
                        where currentgame.Platform == "Nintendo"
                        select currentgame;
foreach(var currentgame in nintendoGameQuery)
{
    WriteLine(currentgame);
}
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Print just the Title of each VideoGame");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Print just the Title of each VideoGame 
games.Select(currentgame => currentgame.Title)
    .ToList()
    .ForEach(title => WriteLine(title));
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Print only distinct game platforms");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Print only distinct game platforms 
games.Select(currentgame => currentgame.Platform)
    .Distinct()
    .ToList()
    .ForEach(currentPlatform => WriteLine(currentPlatform));
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Sum all the Nintendo games");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//sum all the Nintendo games 
double sumOfAllNintendoGames = games
    .Where(item => item.Platform == "Nintendo")
    .Sum(item => item.Price);
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Any games less than $20");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//Any games less than 20 dollars 
//for any, it will seacg if any games match 
bool isAnyGamesLessThan20 = games.Any(item => item.Price < 20);
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("All games less than 50");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//all games less than 50 
// for all it will search for all games that match
bool isAllGamesLessThan20 = games.Any(item => item.Price < 50);
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("No PC Games on sales");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
//no Pc games on sale
bool isNoPcGamesOnSales = games.Any(item => item.Platform == "PC Games");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");
WriteLine("Any games less than $20");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");

