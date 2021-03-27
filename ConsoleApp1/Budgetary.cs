using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Budgetary: Student
    {
        private int stipendy { get; set; } //стипендия бюджетника

        
        public override void show_info()
        {
            //Информация о студенте
            base.show_info();
            Console.WriteLine("Стипендия: " + this.stipendy);
            Console.WriteLine();
        }
        public override void next_kurs()
        {
            //виртуальная функция перевод на след курс
            base.next_kurs();
        }
        public Budgetary(string first_name, string second_name, int age, string profile)
        {
            //конструкто вызывается , если абитуриент поступил и был зачислен на бюджет
            this.first_name = first_name;
            this.second_name = second_name;
            this.age = age;
            this.profile = profile;
            this.status = "Бюджет";
            this.stipendy = 5400;
        }
        public Budgetary(string first_name, string second_name, int age, string profile,int kurs, int nomer_studaka)
        {
            //вызывается в том случае, если платник перевелся на бюджет
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
