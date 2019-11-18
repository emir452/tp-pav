using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;
using entity_builder;


namespace persistence
{
    public class StudentDao : IDao<Student>
    {
        private DataBaseConnection connection;
        private  BuilderStudent builder;
        public StudentDao()
        {
            connection = DataBaseConnection.getInstance();
            builder = new  BuilderStudent();
        }
        public void update(Student student)
        {
            String sql = "update alumnos set nombre=" + student.personalData.name + ",apellido=" + student.personalData.surname + ", dni=" + student.personalData.dni.ToString() + ", telefono=" + student.personalData.telephoneNumber.ToString() + ",fechaNac=" + student.personalData.virtDate.ToString() + ",email" + student.personalData.email + ", password" + student.personalData.password;
            connection.executeDml(sql);
        }

        public void delete(int id)
        {
            string sql = "delete from alumnos where id" + id;
            connection.executeDml(sql);
        }
        public List<Student> selectAll()
        {
            String sql = "select* from alumnos";
            List<Student> results = new List<Student>();
            DataTable table = connection.executeQueri(sql);
            foreach (DataRow i in table.Rows)
            {
                results.Add(builder.createStudent(i));
            }
            return results;
        }
        public void add(Student student)
        {

            string sql = "insert into alumnos  values (@param1, @param2,@param3,@param4, @param5, @param6,@param7)";
            Object[] array = new Object[] { student.personalData.name, student.personalData.surname, student.personalData.dni, student.personalData.virtDate, student.personalData.telephoneNumber, student.personalData.email, student.personalData.password };
            connection.executeDml(sql, array);

        }
        public Student findById(int id)
        {
            String sql = "select * from alumnos a where a.id="+id;
            return builder.createStudent(connection.executeQueri(sql).Rows[0]);


        }
    }
}