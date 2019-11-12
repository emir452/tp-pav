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
            teacher.personalData.id = int.Parse(row[0].ToString());
            teacher.personalData.password = row[1].ToString();
            teacher.personalData.name = row[2].ToString();
            teacher.personalData.surname = row[3].ToString();
            teacher.personalData.dni = int.Parse(row[4].ToString());
            teacher.personalData.telephoneNumber = int.Parse(row[5].ToString());
            teacher.yearEntered = int.Parse(row[6].ToString());
            return teacher;
        }

    }
}
