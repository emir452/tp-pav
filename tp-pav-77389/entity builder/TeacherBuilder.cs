using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;
namespace entity_builder
{
    public class TeacherBuilder
    {
        public Teacher parseTeacher(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            Teacher teacher = new Teacher();
            teacher.id = int.Parse(row[0].ToString());
            teacher.password = row[1].ToString();
            teacher.name = row[2].ToString();
            teacher.surname = row[3].ToString();
            teacher.dni = int.Parse(row[4].ToString());
            teacher.telephoneNumber = int.Parse(row[5].ToString());
            teacher.yearEntered = int.Parse(row[6].ToString());
            return teacher;
        }

    }
}
