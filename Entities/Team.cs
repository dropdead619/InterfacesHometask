using System;
using System.Collections.Generic;
using System.Text;


namespace Entities
{
     public class Team 
    {
        public Worker[] Workers { get; set; }
        public TeamLeader TeamLeader { get; set; }
    }
}
