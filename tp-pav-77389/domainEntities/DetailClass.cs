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
        public Teme teme { get; set;}
        public float calification { get; set;}
        public DetailClass(Teme teme, float calification)
        {
            this.teme = teme;
            this.calification = calification;
        }
public Boolean contains(Teme teme)
        {
            return this.teme.Equals(teme); 
        }
}
}
