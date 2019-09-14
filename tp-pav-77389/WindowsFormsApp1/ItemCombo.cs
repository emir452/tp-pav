using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visnes;
namespace WindowsFormsApp1
{
    public  class ItemCombo
    {
        public Role role   { get; set;}
        public String value { get; set; }
        public ItemCombo(Role role, String value)
        {
            this.role = role;
            this.value = value;
        }
        public String toString()    
        {
            return value;
        }
    }
}
