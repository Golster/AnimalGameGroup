using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalGame.Models
{
    public class DTOGame
    {
        public int ID { get; set; }
        public string PublicID { get; set; }
        public string GameName { get; set; }
        public string NickNameInitiator { get; set; }

        public Player CurrentPlayer { get; set; }

        public DTOGame()
        {
            CurrentPlayer = new Player();
        }

        public DTOGame(Player player)
        {
            CurrentPlayer = player;
        }
    }
}