using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NotStudent : Student
    {
        /*Если абитуриент не поступил, создается объект данного класса который уведомляет 
         о не зачислении в вуз */
        
        public NotStudent(string first_name,string second_name)
        {
            Console.WriteLine((this.first_name = first_name) +" "+ (this.second_name = second_name));
            Console.WriteLine("Вам не хватило баллов для поступления");
        }
    }
}
