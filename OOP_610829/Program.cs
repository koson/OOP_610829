using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_610829
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. instantiation of student
            Student stu3 = new Student("4235345", "Hello World", "male", 3.5f);

        }
    }

    // 1. create class student
    class Student
    {
        // fields
        private string id;
        private string name;
        public string gender;
        private float gpa;

        // Constructor



        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        // REUSE from 2 parameters
        public Student(string id, string name, float gpa) : this(id, name)
        {
            this.gpa = gpa;
        }

        public Student(string id, string name, string gender, float gpa) : this(id, name)
        {
            this.gender = gender;
            this.gpa = gpa;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        internal void SetGPA(float v)
        {
            this.gpa = v;
        }

        internal void SetID(string v)
        {
            this.id = v;
        }
    }
}








