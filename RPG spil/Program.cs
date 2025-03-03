using System;
using RPG_spil;

Console.WriteLine("Game is starting...");
GameManager gameManager = new GameManager();
gameManager.StartGame();

Console.WriteLine("Game Over. Press any key to exit...");
Console.ReadKey();  
