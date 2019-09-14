using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;
namespace persistence
{
    public  class TeacherDao : IDao<Teacher>
    {
        private DataBaseConnection connection;
        private ObjectBuilder parser;
        public TeacherDao()
        {
            connection = DataBaseConnection.getInstance();
            parser = new ObjectBuilder();
            
        }
    public Teacher findById(int id)
        {
            string sql = "select * from profesores p where p.id=@param1";
            return  parser.parseTeacher(connection.executeQueri(sql, id)); 
}
public List<Teacher> selectAll()
        {

        }
        public void update(Teacher teacher)
        {
       
                }
        public void delete(int id)
        {
             }
        public void add(Teacher teacher)
        {


        }
        }
}
