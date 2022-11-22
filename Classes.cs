using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class Classes
    {
        public static void Execute()
        {
            ExampleProperties ep = new ExampleProperties();
            ep.prop2 = "Tired";
            ep.GetProp3 = "Prop3 is dumb";
            string s3 = ep.GetProp3;

            float area = 2 * Math.PI * 2.0f;
            area = Math.CalcArea(area);

            Student milton = new Student();
            milton.Name = "Milton"; //uses getter
            Console.WriteLine("Students name is: {0}", milton.Name);

            milton.GPA = 10f;
            Console.WriteLine("Milton GPA: {0}", milton.GPA);
            milton.GPA = 3.6f;
            Console.WriteLine("Milton GPA: {0}", milton.GPA);

            Console.WriteLine("Milton Age: {0}", milton.Age);

            Student chad = new Student("Chad", 37, 3.5f, 12);

            Alumni a = new Alumni("Bob", 3.4f, 37, 2020);
        }
    }
    //Protection levels
    //Public - accessale to everybody
    //Private - only this class can see
    //Proteced this class and any class that inherits form it
    //Internal - only this assembly or project

    class Alumni : Student
    {
        private int yearGraduated;

        public Alumni()
        {
            Console.WriteLine("Derived class contructor 0 params");
            Console.WriteLine("Alumi Name: {0}", base.name);
            Console.WriteLine("Granduted: {0}", yearGraduated);
        }

        public Alumni(string name, float gpa, int cohort, int yearGraduated)// : base(name, cohort, gpa)
        {
            Console.WriteLine("Alumni class with many perameteres");
            this.yearGraduated = yearGraduated;
            Console.WriteLine("Year Grad: {0}", yearGraduated);

        }
    }

    class Student
    {
        protected string name;
        protected int cohort;
        protected float gpa;

        public int numOfStudents;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0 && value <= 4.0) gpa = value;
            }
        }

        //auto-implemented property - auto creates a private field only accessable through gets/sets
        //cout remove get or set
        public int Age { get; set; } = 21;

        public Student()
        {
            Age = 26;
            Name = "Bob";
            Console.WriteLine("In Student Constructor 0 perams");
            numOfStudents++;
        }

        public Student(string name, int cohort, float gpa, int age)
        {
            Name = name;
            this.cohort = cohort;
            this.gpa = gpa;
            Age = age;

            Console.WriteLine("student constructor with all perams");
        }

        public void HowManyStudents()
        {
            Console.WriteLine("Number of students: {0}", numOfStudents);
        }
    }

    static class Math //if static class forces all methods in it to be static
    {
        public const float PI = 3.14159f; //constant. can't be changed after creation
        
        //static classes do not need instantiation
        public static float CalcArea(float radius)
        {
            return 2 * PI * radius;
        }
    }

    class ExampleProperties
    {
        public string prop2; //quick and easy, but saving loading not validated
        private string prop3; //better - create private variables, control access with properties

        public string GetProp3
        {
            get { return prop3; }
            set { prop3 = value; }
        }
    }
}
