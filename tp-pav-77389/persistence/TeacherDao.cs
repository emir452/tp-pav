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
    public  class TeacherDao : IDao<Teacher>
    {
         private IDatabaseConnection connection;
        private TeacherBuilder builder;
        public TeacherDao()
        {
            connection = DataBaseConnection.getInstance();
            builder= new TeacherBuilder();
            
        }
    public Teacher findById(int id)
        {
            string sql = "select * from profesores p where p.id="+id;
            return  builder.parseTeacher(connection.executeQueri(sql).Rows[0]); 
}
public List<Teacher> selectAll()
        {
            List<Teacher> results = new List<Teacher>();
            String sql = "select * from profesores";
            DataTable table = connection.executeQueri(sql);
            foreach (DataRow i  in table.Rows)
            {
                results.Add(builder.parseTeacher(i));
}
            return results;
}
        public void update(Teacher teacher)
        {
       
                }
        public void delete(int id)
        {
            String sql = "delete profesores where id=" + id;
            connection.executeDml(sql);
             }
        public void add(Teacher teacher)
        {
            string sql = "insert in to profesores   values (@param1, @param2,@param3,@param4,@param5,@param6,@param7";
            Object[] array = new object[] { teacher.personalData.name, teacher.personalData.surname, teacher.personalData.dni, teacher.personalData.virtDate, teacher.personalData.telephoneNumber, teacher.personalData.email, teacher.personalData.password };
            connection.executeQueri(sql, array);
}
    }
}
