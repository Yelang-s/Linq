using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class KongfuBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public string Detail { get; set; }

        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Power:{Power},Detail:{Detail}";
        }
    }
}
