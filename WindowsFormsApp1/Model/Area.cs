using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Area
    {
        public Area(int id, string name)
        {
            this.AreaId = id;
            this.AreaName = name;
        }
        public int AreaId { get; set; }

        public string AreaName { get; set; }
        public override string ToString()
        {
            return AreaName;
        }
    }
}
