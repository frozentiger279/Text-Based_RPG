﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * notes: 
 * program inits gamemanager and runs the startgame
 * gamemanager's startgame inits game pieces (map player enemy(ies)) loads map and holds gameloop (clear->draw->update)
 * map has the maploader and draw method as well as holds method to detect contact (boundaries) 
 * given to players in construct so they have access to boundaries
 * gamecharacter holds any similar values game characters would have contains draw method of characters
 * player and enemy inherit gamecharacter and have their own movements
 * ***Need to find way to connect player-enemy so that they can collide***
 * ***Have not found a way to do so while practicing OOP***
 */
namespace Text_Based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.WriteLine("Welcome to Robert's text based RPG");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey(true);

            //initilize gamemanager and run the start of the game
            GameManager gameManager = new GameManager();
            gameManager.StartGame();
        }
    }
}
