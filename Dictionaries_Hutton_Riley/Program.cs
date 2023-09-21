// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

//a dictionary that takes an int as the key and a string as the value
Dictionary<int, string> topGames = new Dictionary<int, string>();
topGames.Add(1, "Tiny Tina's Wonderlands");
topGames.Add(2, "CS:GO");
topGames.Add(3, "Halo 3");
topGames.Add(4, "Elden Ring");
topGames.Add(5, "Sonic Adventures 2");
topGames.Add(6, "Kirby Airride");
topGames.Add(7, "Donky Kong 64");
topGames.Add(8, "Runescape");
topGames.Add(9, "GTA: San Andreas");
topGames.Add(10, "Valorant");

//Loops through the topGames dictionary and prints out each Key/Value pair on a new line
foreach (KeyValuePair<int, string> kvp in topGames)
{
    Console.WriteLine($"Key: {kvp.Key}, value: {kvp.Value}");
}

//if the key contains 1 it will print that string to console
if (topGames.ContainsKey(1))
{
    Console.WriteLine($"My favorite game is : {topGames[1]}");
}

//empty string called result
string result = "";

//TryGetValue method on topGames for key 11
topGames.TryGetValue(11, out result);

//If it outputs something to result then it prints the result to console
if (result != "")
{
    Console.WriteLine(result);
}
//else it prints, "There is no game in the eleventh position."
else
{
    Console.WriteLine("There is no game in the eleventh position.");
}

//Switches key 5 with a new game
if (topGames.ContainsKey(5))
{
    topGames[5] = "Rocket League";
}

//Prints the new key 5
Console.WriteLine(topGames[5]);

//new hashtable equal to topgames
Hashtable hashTable = new Hashtable(topGames);

//new string called favgame and sets favgame to key 1
string favGame = (string)hashTable[1];

//Prints favgame to console
Console.WriteLine($"Favorite Games: {favGame}");

//another hashtable using collection-initializer syntax, called capitals.
Hashtable capitals = new Hashtable()
{
    { "Oklahoma", "Oklahoma City" },
    { "New York", "Albany" },
    { "Texas", "Austin" },
    { "Ohio", "Colombus" }
};

//Loop through the capitals hashtable and print out the DictionaryEntry objects key and value on a new line
foreach (DictionaryEntry kvp in capitals)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

//Clears all elements in the capitals hashtable.
capitals.Clear();