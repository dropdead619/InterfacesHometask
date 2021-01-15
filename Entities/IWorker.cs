using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IWorker
    {
        public int WorkerId { get; set; }
        public House Build(House house);
        public void Check(House house);
    }
}
