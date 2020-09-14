using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string name;
        public string major;
        private double gpa;

        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.Gpa = gpa;
        }

        public bool Honors()
        {
            if(this.gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

        //Define Getters / Setters
        public double Gpa
        {
            get { return gpa; }
            //Can restrict what inputs can be entered for Setter
            set {
                if (value == 3.0 || value == 3.5)
                {
                    gpa = value;
                }
                else
                {
                    gpa = 0.0;
                };
            }
        }
    }
}
