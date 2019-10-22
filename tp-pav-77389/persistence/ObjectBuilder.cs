using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;
namespace persistence
{
     public class ObjectBuilder
    {
public Student parseStudent(DataRow row)
{
            if (row==null)
            {
                return null;
            }
            Student student = new Student();
            student.id = int.Parse(row[0].ToString());
            student.name = row[1].ToString();
            student.surname = row[2].ToString();
            student.dni = int.Parse(row[3].ToString());
            student.virtDate = DateTime.Parse(row[4].ToString());
            return student;
}
        
      
    }
}
