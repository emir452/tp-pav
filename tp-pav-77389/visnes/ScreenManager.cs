using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using presentation; 
namespace visnes
{
     public class ScreenManager
    {
        private Sesion sesion;
        public ScreenManager(Sesion sesion)
        {
            this.sesion = sesion;
        }
        public void showScreen()
        {
            if(sesion.user.role==Role.Roles.MANAGER)
            {

                 }


        }
    }
}
