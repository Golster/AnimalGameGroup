using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalGame.Models
{
    public class DTOGameSession
    {
        public int PlayerId { get; set; }
        public List<Player> Players = new List<Player>();
        public List<AnimalName> Animals = new List<AnimalName>();

        public DTOGame CurrentGame { get; set; }

        public DTOGameSession(DTOGame game)
        {
            CurrentGame = game;
        }


    
    }
}