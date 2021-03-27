using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Extrabudgetary: Student
    {
        private int price { get; set; }   //plata za obuchenie
        

        public Extrabudgetary(string first_name, string second_name, int age, string profile)
        {
            // Вызываем этот конструктор ,если абитуриент зачислен, но не смог попасть на бюджет
            this.first_name = first_name;
            this.second_name =second_name;
            this.age =age;
            this.profile =profile;
            this.status = "Платное";
            this.price = 175000;
        }
        public override void show_info()
        {
            //виртуальная функция для отображения информации о студенте
            base.show_info();
            Console.WriteLine("Плата за обучение: " + this.price);
            Console.WriteLine();
        }
        public override void oplatit()
        {
            //оплата обучения платником
             base.oplatit();
        }
        public override void next_kurs()
        {
            //зачисление на следующий курс, если оплачено обучений
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
