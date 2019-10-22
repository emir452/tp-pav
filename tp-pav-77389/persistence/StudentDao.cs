using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;


namespace persistence
{
    public class StudentDao : IDao<Student>
    {
        private DataBaseConnection connection;
        private ObjectBuilder builder;
        public StudentDao()
        {
            connection = DataBaseConnection.getInstance();
            builder = new ObjectBuilder();
        }
        public void update(Student student)
        {
            String sql = "update alumnos set nombre=" + student.name + ",apellido=" + student.surname + ", dni=" + student.dni.ToString() + ", telefono=" + student.telephoneNumber.ToString() + ",fechaNac=" + student.virtDate.ToString() + ",email" + student.email + ", password" + student.password;
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
            ObjectBuilder builder = new ObjectBuilder();
            List<Student> results = new List<Student>();
            DataTable table = connection.executeQueri(sql);
            foreach (DataRow i in table.Rows)
            {
                results.Add(builder.parseStudent(i));
            }
            return results;
        }
        public void add(Student student)
        {

            string sql = "insert into alumnos  values (@param1, @param2,@param3,@param4, @param5, @param6,@param7)";
            Object[] array = new Object[] { student.name, student.surname, student.dni, student.virtDate, student.telephoneNumber, student.email, student.password };
            connection.executeDml(sql, array);

        }
        public Student findById(int id)
        {
            String sql = "select * from alumnos a where a.id="+id;
            return builder.parseStudent(connection.executeQueri(sql).Rows[0]);


        }
    }
}