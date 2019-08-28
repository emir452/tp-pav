using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    public class Class
    {
        private Teacher teacher;
        private Student student;
        private List<DetailClass> detailClass;
        private DateTime date;
        public Class(Teacher teacher, Student student)
        {
            detailClass = new List<DetailClass>();
            this.teacher = teacher;
            this.student = student;
            date = DateTime.Now;
}
        public int MyProperty { get; set; }
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