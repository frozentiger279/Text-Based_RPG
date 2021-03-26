﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    class GameManager
    {
        public void StartGame()
        {
            //init pieces of games
            Map map = new Map();
            map.MapLoader("Map.txt");

            Player player = new Player();
            Enemy enemy = new Enemy(1);

            while(player.Lives >= 1)
            {
                map.Draw();
                enemy.Draw();
                player.Draw();

                player.Update(map,enemy);
                enemy.Update(map, player);
            }
        }
    }
}
