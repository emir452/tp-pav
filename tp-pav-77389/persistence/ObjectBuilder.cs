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
            Student student = new Student();
            student.id = int.Parse(row[0].ToString());
            student.name = row[1].ToString();
            student.surname = row[2].ToString();
            student.dni = row[3].ToString();
            student.virtDate = DateTime.Parse(row[4].ToString());
            return student;
}
        public Manager parseManager(DataRow row)
{
            Manager manager = new Manager();
            manager.id = int.Parse(row[0].ToString());
            manager.name = row[1].ToString();
            manager.surname = row[2].ToString();
            manager.email = row[3].ToString();
            return manager;
        }
        public Teacher parseTeacher(DataRow row)
{
            Teacher teacher = new Teacher();
            teacher.id = int.Parse(row[0].ToString());
            teacher.password= row[1].ToString();
            teacher.name=row[2].ToString();
            teacher.surname= row[3].ToString();
            teacher.dni= int.Parse(row[4].ToString());
            teacher.telephoneNmber= int.Parse(row[5].ToString());
            teacher.yearEntered = int.Parse(row[6].ToString());
            return teacher;
        }

      
    }
}
