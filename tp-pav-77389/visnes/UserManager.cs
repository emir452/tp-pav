using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;
    namespace visnes
{
    public class UserManager
    {
        public UserManager()
        {

}
        public  void login(int id, String pasword, Role rol)
        {
            Sesion sesion = rol.login(id,pasword);
            
           
}

}
}
