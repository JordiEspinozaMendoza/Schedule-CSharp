using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_library.Views
{
    class ListItem
    {
        public String Name { get; set; }
        public Object Value { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
