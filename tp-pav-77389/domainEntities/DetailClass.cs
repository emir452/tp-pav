using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    /// <summary>
    /// </summary>
    class DetailClass
    {
        private Teme teme;
        private float calification;
        public DetailClass(Teme teme, float calification)
        {
            this.teme = teme;
            this.calification = calification;
        }
public int MyProperty { get; set; }
public Boolean contains(Teme teme)
        {
            return this.teme.Equals(teme); 
        }
}
}
