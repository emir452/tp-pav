﻿using System;
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
        public Teme teme { get; set; }
        public DateTime date { get; set; }
        public float calification { get; set;} 
        public String observations { get; set;}
        public Class(Teacher teacher, Student student)
        {
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