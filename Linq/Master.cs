using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Master
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string KongfuName { get; set; }
        public int Level { get; set; }
        public string Menpai { get; set; }

        public override string ToString()
        {
            return $"Id:{Id},Name{Name},Age:{Age},Kongfu:{KongfuName},Level:{Level},Menpai:{Menpai}";
        }
    }
}
