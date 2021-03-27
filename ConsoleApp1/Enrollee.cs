using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1
{
    class Enrollee
    {
        private string first_name { get; set; }
        private string second_name { get; set; }
        private string profile { get; set; }
        private int age { get; set; }
        private int vstup_ball { get; set; }

        public Student transform()
        {
            //зачисление в студенты
            if(this.vstup_ball>200)
            {
                return new Budgetary(this.first_name,this.second_name,this.age, this.profile);
            }
            else if((this.vstup_ball>150) && (this.vstup_ball<=200))
            {
                return new Extrabudgetary(this.first_name, this.second_name, this.age, this.profile);
            }
            else
            {
                return new NotStudent(this.first_name, this.second_name);
            }
        }

        public Enrollee (string first_name,string second_name,int age, int vstup_ball,string profile)
        {
            //инициализация абитуриента
            this.first_name = first_name;
            this.second_name = second_name;
            this.age = age;
            this.vstup_ball = vstup_ball;
            this.profile = profile;

        }
    }
}
