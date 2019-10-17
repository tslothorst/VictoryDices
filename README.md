# VictoryDices
A Razzle Dazzle simulator written in C#

This repo contains two C# projects for a program which simulates the game known as Razzle (Dazzle) or Victory Dices (other possible names are: Football, Baseball, Ten Points Win, Mo-Co, Indian Poker or Cajun Bingo).

The goal of the game is to get to a 100 points in order to win. A player will throw eight dices per round and the total of the dice determines where on the board the player will end up. Some field result in points being added to the goal of getting a 100 points. Other fields add another prices for the player to potentially win. Throwing 29 with the dice will result in the players fee per round to double. This effect is cummulative. 

Razzle is a game which is statistically very hard to win. Chances a player will run out of money before winning are high due to the distribution of points. For a complete overview of the math behind the game read the Wikipedia article on the game: https://en.wikipedia.org/wiki/Razzle_(game).

The programs will play the game untill it reaches the score of 100. Output will be how many rounds were needed, how many prices are won and how much it would cost to get to this result. Base price for a round of play starts at $1.

Both programs play the game the same, one is a console application and the other is a winforms version. The projects were originally targeted for the .NET 4.7.2 framework.
