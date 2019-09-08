using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public  class ItemCombo
    {
        public  visnes.Role.Roles  key { get; set;}
        public String value { get; set; }
        public ItemCombo(visnes.Role.Roles key, String value)
        {
            this.key = key;
            this.value = value;
        }
        public String toString()    
        {
            return value;
        }
    }
}
