using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalGame.Models
{
    public class DTOGame
    {
        public Game GameRound { get; set; }

        public Player CurrentPlayer { get; set; }

        public DTOGame()
        {
            CurrentPlayer = new Player();

            GameRound = new Game();
        }


        public DTOGame(Player player, Game game)
        {
            CurrentPlayer = player;

            GameRound = game;
        }
    }
}