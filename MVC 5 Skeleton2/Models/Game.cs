using System;
using System.Collections.Generic;

namespace MVC_5_Skeleton2.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }
    }
}