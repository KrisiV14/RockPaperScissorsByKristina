﻿const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid Input. Try Again...";
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computrMove = "";

switch (computerRandomNumber)
{

    case 1:
        computerMove = Rock;
        break;

    case 2:
        computerMove = Paper;
}
