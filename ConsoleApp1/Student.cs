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
            //создаем ключ(предмет) без значений (оценок)
            List<int> list = new List<int>();
            record_book.Add(discipline,list);
        }
        public void record_mark(string discipline,int mark)
        {
            //добавляем в словарь(зачетку) значение (оценку) по ключу(предмету)
            List<int> list = new List<int>();
            if(record_book.TryGetValue(discipline, out list))
            {
                list.Add(mark);
            }
        }
        public void update_mark(string discipline,int semestr,int mark)
        {
            //изменяем значение(оценку) в словаре(зачетке) по ключу(предмету) и индеку(семестру)
            List<int> list = new List<int>();
            if (record_book.TryGetValue(discipline, out list))
            {
                list[semestr - 1] = mark;
            }
        }
        public void show_record_book()
        {
            // выводим содержимое зачетки(словаря)
            foreach (KeyValuePair<string, List<int>> keyValue in record_book)
            {
                Console.Write(keyValue.Key + " - ");
                keyValue.Value.ForEach(mark=>Console.Write(mark + " "));
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        public Student()
        {
            //инициализаия объекта 
            this.nomer_studaka = ++counter;
            this.kurs = 1;
        }

        public virtual void show_info()
        {
            //вывод информации о студенте
            Console.WriteLine("ФИО: " + (this.first_name) + " " + (this.second_name));
            Console.WriteLine("Возраст: " + this.age);
            Console.WriteLine("Направление:" + this.profile);
            Console.WriteLine("Форма обучения:" + this.status);
            Console.WriteLine("Курс:" + this.kurs);
            Console.WriteLine("Номер студенческого: " + this.nomer_studaka);
            

        }
        public virtual void oplatit()
        {
            //оплата обучения
            this.oplata = true;
        }

        public virtual void next_kurs()
        {
            if(this.kurs==4)//у нас только бакалавриат, поэтому с 4 курса выше не прыгнуть
            { return; }

            int count = 0;
            int tmp = 0;
            foreach (KeyValuePair<string, List<int>> keyValue in record_book)
            {
                // смотрим значение по ключам в словаре и считаем количество 0 - долгов
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
                    //если долгов меньше 3, переводим студента
                    this.kurs++;
                    return;
                }
                else
                {
                    //иначе требуем закрыть долги
                    Console.WriteLine("Закройте академические задолженности");
                    Console.WriteLine();
                }
                
            }
        }
        public  Budgetary up_budgetary()
        {
            //перевод платника на бюджет
            return new Budgetary(this.first_name, this.second_name, this.age, this.profile, this.kurs, this.nomer_studaka);
            
        }

    }
}
