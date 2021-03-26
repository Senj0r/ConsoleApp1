using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        protected int kurs { get; set; }
        protected bool oplata { get; set; }
        protected string status { get; set; }

        private static int counter = 0;
       
        protected string first_name { get; set; }
        protected string second_name { get; set; }
        protected string profile { get; set; }
        protected int age { get; set; }
        protected int nomer_studaka { get; set; }

        protected Dictionary<string, List<int>> record_book = new Dictionary<string, List<int>>();


        public void create_descipline (string discipline)
        {
            List<int> list = new List<int>();
            record_book.Add(discipline,list);
        }
        public void record_mark(string discipline,int mark)
        {
            List<int> list = new List<int>();
            if(record_book.TryGetValue(discipline, out list))
            {
                list.Add(mark);
            }
        }
        public void update_mark(string discipline,int semestr,int mark)
        {
            List<int> list = new List<int>();
            if (record_book.TryGetValue(discipline, out list))
            {
                list[semestr - 1] = mark;
            }
        }
        public void show_record_book()
        {
            foreach (KeyValuePair<string, List<int>> keyValue in record_book)
            {
                Console.Write(keyValue.Key + " - ");
                keyValue.Value.ForEach(mark=>Console.Write(mark + " "));
                Console.WriteLine();
            }
        }
        public Student()
        {
            this.nomer_studaka = ++counter;
            this.kurs = 1;
        }

        public virtual void show_info()
        {

            Console.WriteLine("ФИО: " + (this.first_name) + " " + (this.second_name));
            Console.WriteLine("Возраст: " + this.age);
            Console.WriteLine("Направление:" + this.profile);
            Console.WriteLine("Форма обучения:" + this.status);
            Console.WriteLine("Курс:" + this.kurs);
            Console.WriteLine("Номер студенческого: " + this.nomer_studaka);


        }
        public virtual void oplatit()
        {
            this.oplata = true;
        }

        public virtual void next_kurs()
        {
            int count = 0;
            int tmp = 0;
            foreach (KeyValuePair<string, List<int>> keyValue in record_book)
            {
                int counter =keyValue.Value.Count;
                for(int i=1;i<counter;i++)
                {
                    tmp = keyValue.Value[counter-i];
                    if (tmp == 0)
                    {
                        count++;
                    }
                }
                if(count<3)
                {
                    this.kurs++;
                    return;
                }
                else
                {
                    Console.WriteLine("Закройте академические задолженности");
                }
                
            }
        }
        public Budgetary up_budgetary()
        {
            return new Budgetary(this.first_name, this.second_name, this.age, this.profile, this.kurs,this.nomer_studaka);
        }

    }
}
