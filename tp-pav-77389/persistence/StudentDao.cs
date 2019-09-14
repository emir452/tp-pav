using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
}
    
    public void delete(int id)
    {

    }
    public List<Student> selectAll()
    {
    }
    public void add(Student student)
    {

            string sql = "insert in to alumnos  values (@param1, @param2,@param3,@param4";
            Object array = { student.name, student.surname, student.dni, student.virtDate };
            connection.executeQueri(sql, array);

    }
    public Student  findByID(int id)
    {
            String sql = "select * from alumnos a where a.id=@param1";
            return builder.parseStudent(connection.executeQueri(sql, id));


}
}
}