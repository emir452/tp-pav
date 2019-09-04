using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    public class Class
    {
        public Teacher teacher { get; set;}
        public Student student { get; set; }
        private List<DetailClass> detailClass;
        public DateTime date { get; set; }
        public Class(Teacher teacher, Student student)
        {
            detailClass = new List<DetailClass>();
            this.teacher = teacher;
            this.student = student;
            date = DateTime.Now;
}
        public Boolean contains(Student student)
        {
            return this.student.Equals(student);
}
        public Boolean contains(Teacher teacher)
        {
            return this.teacher.Equals(teacher);
}
        public Boolean ItsFromTheDate(DateTime date)
        {
            return this.date.Equals(date);
}
    }
}