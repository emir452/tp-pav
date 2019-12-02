using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace persistence
{
     public class StudentTemeReportQueri
    {
        public  DataTable createQueri()
        {
            return DataBaseConnection.getInstance().executeQueri("select a.nombre, t.nombre from clases c inner join Alumnos a  on (c.legajo_alumno=a.legajo) inner join temas t on(c.tema=t.id_tema) group by t.id_tema");

}
       

    }
}
