using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TeamLeader : IWorker
    {
        public int WorkerId { get; set; }
        public House Build(House house)
        {
            throw new NotImplementedException();
        }
        public void Check(House house)
        {
            throw new NotImplementedException();
        }
    }
}
