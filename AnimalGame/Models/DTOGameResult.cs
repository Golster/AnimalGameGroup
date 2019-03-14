using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalGame.Models
{
    public class DTOGameResult
    {
        public List<AnimalName> ReceivedNames = new List<AnimalName>();

        public DTOGame CurrentGame { get; set; }

        public DTOGameResult()
        {
        }

        public DTOGameResult(DTOGame game)
        {
            CurrentGame = game;
        }
    }
}