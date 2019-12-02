using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace persistence
{
     public class SimpleStudentReportQueri
    {
        private IDatabaseConnection d;
        public  SimpleStudentReportQueri()
        {
            d = DataBaseConnection.getInstance();
        }
public DataTable createQueri()
        {
           return d.executeQueri("select a.nombre,  t.nombre, c.nota, c.fecha, c.observaciones from clases c inner join Alumnos a on (c.legajo_alumno=a.legajo) inner join Temas t on (c.tema=t.id_tema) group by c.nota");
}
    }
}
