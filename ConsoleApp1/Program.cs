using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enrollee a1 = new Enrollee("Анна","Куликова",19,231,"Информатика и вычислительная техника");
            Student s1= a1.transform();
            s1.show_info();
            s1.create_descipline("Высшая математика");
            s1.record_mark("Высшая математика", 5);
            s1.record_mark("Высшая математика", 3);  
            s1.record_mark("Высшая математика", 3);
            s1.create_descipline("Анализ бизнес-процессов");
            s1.record_mark("Анализ бизнес-процессов", 0);  
            s1.record_mark("Анализ бизнес-процессов", 4);
            s1.create_descipline("Философия");
            s1.record_mark("Философия", 5);  
            s1.record_mark("Философия", 4);  
            s1.show_record_book();
            s1.update_mark("Высшая математика", 2, 4);
            s1.show_record_book();
            s1.next_kurs();
            s1.show_info();
            Enrollee a2 = new Enrollee("Коля", "Законов", 17, 178, "Автоматизация");
            Student s2 = a2.transform();
            s2.show_info();
            s2.create_descipline("АПСУ");
            s2.record_mark("АПСУ", 4);
            s2.record_mark("АПСУ", 3);
            s2.record_mark("АПСУ", 5);
            s2.oplatit();
            s2.next_kurs();
            s2.show_info();
            s2.show_record_book();
            Student s3 = s2.up_budgetary();
            s3.show_info();
        }
    }
}
