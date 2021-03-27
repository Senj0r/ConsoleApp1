using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Budgetary: Student
    {
        private int stipendy { get; set; }

        
        public override void show_info()
        {
            base.show_info();
            Console.WriteLine("Стипендия: " + this.stipendy);
            Console.WriteLine();
        }
        public override void next_kurs()
        {
            base.next_kurs();
        }
        public Budgetary(string first_name, string second_name, int age, string profile)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.age = age;
            this.profile = profile;
            this.status = "Бюджет";
            this.stipendy = 5400;
        }
        public Budgetary(string first_name, string second_name, int age, string profile,int kurs, int nomer_studaka)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.age = age;
            this.kurs = kurs;
            this.profile = profile;
            this.nomer_studaka = nomer_studaka;
            this.status = "Бюджет";
            this.stipendy = 5400;
        }

    }
}
