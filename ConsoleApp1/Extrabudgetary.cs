using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Extrabudgetary: Student
    {
        private int price { get; set; }
        

        public Extrabudgetary(string first_name, string second_name, int age, string profile)
        {
            this.first_name = first_name;
            this.second_name =second_name;
            this.age =age;
            this.profile =profile;
            this.status = "Платное";
            this.price = 175000;
        }
        public override void show_info()
        {
            base.show_info();
            Console.WriteLine("Плата за обучение: " + this.price);
        }
        public override void oplatit()
        {
             base.oplatit();
        }
        public override void next_kurs()
        {

            if (this.oplata)
            {
                base.next_kurs();
            }
            else
            {
                Console.WriteLine("Внесите плату за обчуние: ");
                return;
            }
            
        }
        

    }
}
