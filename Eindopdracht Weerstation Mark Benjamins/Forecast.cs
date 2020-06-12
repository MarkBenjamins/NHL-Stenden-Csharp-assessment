using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_Weerstation_Mark_Benjamins
{
    class Forecast
    {
        public List<list> list { get; set; }
    }
    public class list
    {
        public main main { get; set; }
    }
    public class main
    {
        public double temp { get; set; }
    }
}
