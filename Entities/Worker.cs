using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Worker : IWorker
    {
        public int WorkerId { get; set; }

        public House Build(House house)
        {

            return new House();
        }

        public void Check(House house)
        {
            throw new NotImplementedException();
        }
    }
}
