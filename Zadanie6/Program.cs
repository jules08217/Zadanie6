using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zadanie5
{
    class Student
    {
        public int ID;
        public string FIO;
        public string Group;
        public string Data;

        ArrayList student = new ArrayList();
        ArrayList students = new ArrayList();
        ArrayList fio = new ArrayList();
        ArrayList id = new ArrayList();
        ArrayList data = new ArrayList();
        public void dobavit()
        {
            Console.WriteLine("Введите данные студента");
            Random r = new Random();
            ID = r.Next(20);
            Console.WriteLine("Введите ФИО");
            FIO = Console.ReadLine();
            Console.WriteLine("Введите Группу");
            Group = Console.ReadLine();
            Console.WriteLine("Введите Дату(dd.mm.yyyy)");
            Data = Console.ReadLine();
            student = new ArrayList();
            student.Add(ID);
            student.Add(FIO);
            student.Add(Group);
            student.Add(Data);
            id.Add(ID);
            fio.Add(FIO);
            data.Add(Data);
            string s = "ID студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students.Add(s);
        }
        public void izmenit()
        {
            int n = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + n + " ), которого надо изменить");
            int s = Convert.ToInt32(Console.ReadLine());
            fio.RemoveAt(s);
            Console.WriteLine("Выберите, что нужно изменить: \n1 - ФИО\n2 - Группу\n3 - Дату рождения");
            int v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine("Введите ФИО");
                string fiO = Console.ReadLine();
                student[1] = fiO;
                fio.Add(fiO);
            }
            if (v == 2)
            {
                Console.WriteLine("Введите Группу");
                string group = Console.ReadLine();
                student[2] = group;
            }
            if (v == 3)
            {
                Console.WriteLine("Введите Дату(dd.mm.yyyy)");
                string data = Console.ReadLine();
                student[3] = data;
            }
            string st = "ID студента: " + student[0] + "\nФИО: " + student[1] + "\nГруппа: " + student[2] + "\nДата: " + student[3];
            students[s] = st;
        }

        public void delite()
        {
            int n = students.Count - 1;
            Console.WriteLine("Вебирете индекс студента (от 0 до " + n + " ), которого надо удалить");
            int s = Convert.ToInt32(Console.ReadLine());
            students.RemoveAt(s);
        }
        public void inf()
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + "\n");
            }
        }

        public void infFIO()
        {
            Console.WriteLine("Список студентов:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(fio[i]);
            }
        }

        public void infID()
        {
            Console.WriteLine("Id студентов:");
            int k = 0;
            for (int i = 0; i < id.Count; i++)
            {
                Console.WriteLine(id[i]);
                k++;
            }
            int[] c = new int[k];
            id.CopyTo(c);
            Console.WriteLine("Введите ID студента");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Информация о студенте:");
            for (int j = 0; j < id.Count; j++)
            {
                if (d == c[j])
                {
                    Console.WriteLine(students[j]);
                }
            }
        }

        public void Vdata()
        {
            Console.WriteLine("Id студентов:");
            int k = 0;
            int [] cc = new int[4];
            int c1 = 0;
            int voz;
            for (int i = 0; i < id.Count; i++)
            {
                Console.WriteLine(id[i]);
                k++;
            }
            int[] c = new int[k];
            id.CopyTo(c);
            Console.WriteLine("Введите ID студента");
            int d = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < id.Count; j++)
            {
                if (d == c[j])
                { 
                    string s = data[j].ToString();
                    char[] ss = s.ToCharArray(); 
                    cc[0] = ss[6] - '0';
                    cc[1] = ss[7] - '0';
                    cc[2] = ss[8] - '0';
                    cc[3] = ss[9] - '0';       
                    for(int i= 0; i < 4; i++)
                    {   
                        c1 = c1 * 10 + cc[i];   
                    }
                }
            }
            voz = 2020 - c1;
            Console.WriteLine("Возраст студента: " + voz);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.dobavit(); Console.WriteLine();
            s.dobavit(); Console.WriteLine();
            s.dobavit(); Console.WriteLine();
            s.infFIO(); Console.WriteLine();
            s.infID(); Console.WriteLine();
            s.Vdata();
        }
    }
}

