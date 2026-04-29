using System;

namespace StudentRegistryApp
{
    public class Student
    {
        private static int nextId = 101;
        public int StudentId;
        public string Name;
        public string Faculty;
        private double studentGpa;

        public double GPA
        {
            get { return studentGpa; }
            set
            {
                if (value >= 0.0 && value <= 4.0)
                    studentGpa = value;
                else
                    throw new Exception("Ошибка: GPA должен быть от 0.0 до 4.0");
            }
        }

        public Student(string name, double gpa, string faculty)
        {
            this.StudentId = nextId++;
            this.Name = name;
            this.GPA = gpa;
            this.Faculty = faculty;
        }

        public string GetInfo()
        {
            return "ID: " + StudentId + " | Имя: " + Name + " | GPA: " + GPA + " | Фак: " + Faculty;
        }
    }

    public class Registry
    {
        private Student[] studentsArray = new Student[100];
        private int count = 0;

        public void Add(Student s)
        {
            if (count < 100)
            {
                studentsArray[count] = s;
                count++;
                Console.WriteLine("Добавлено успешно.");
            }
            else
            {
                Console.WriteLine("Реестр переполнен!");
            }
        }

        public void FindById(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (studentsArray[i].StudentId == id)
                {
                    Console.WriteLine(studentsArray[i].GetInfo());
                    return;
                }
            }
            Console.WriteLine("Студент не найден.");
        }

        public void FindByName(string name)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (studentsArray[i].Name == name)
                {
                    Console.WriteLine(studentsArray[i].GetInfo());
                    found = true;
                }
            }
            if (!found) Console.WriteLine("Совпадений нет.");
        }

        public void GetTop(int n)
        {
            if (count == 0) return;

            Student[] temp = new Student[count];
            for (int i = 0; i < count; i++) temp[i] = studentsArray[i];

            for (int i = 0; i < temp.Length - 1; i++)
            {
                for (int j = 0; j < temp.Length - i - 1; j++)
                {
                    if (temp[j].GPA < temp[j + 1].GPA)
                    {
                        Student t = temp[j];
                        temp[j] = temp[j + 1];
                        temp[j + 1] = t;
                    }
                }
            }

            int limit = n;
            if (n > count) limit = count;

            Console.WriteLine("--- ТОП " + limit + " ---");
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(temp[i].GetInfo());
            }
        }

        public void PrintAll()
        {
            if (count == 0) Console.WriteLine("Реестр пуст.");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(studentsArray[i].GetInfo());
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Registry reg = new Registry();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("1. Добавить | 2. По ID | 3. По имени | 4. Топ N | 5. Все | 6. Выход");
                Console.Write("Выбор: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    try
                    {
                        Console.Write("Имя: "); string n = Console.ReadLine();
                        Console.Write("GPA: "); double g = double.Parse(Console.ReadLine());
                        Console.Write("Факультет: "); string f = Console.ReadLine();
                        reg.Add(new Student(n, g, f));
                    }
                    catch { Console.WriteLine("Ошибка ввода!"); }
                }
                else if (choice == "2")
                {
                    Console.Write("Введите ID: ");
                    int id = int.Parse(Console.ReadLine());
                    reg.FindById(id);
                }
                else if (choice == "3")
                {
                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();
                    reg.FindByName(name);
                }
                else if (choice == "4")
                {
                    Console.Write("Сколько человек показать? ");
                    int n = int.Parse(Console.ReadLine());
                    reg.GetTop(n);
                }
                else if (choice == "5")
                {
                    reg.PrintAll();
                }
                else if (choice == "6")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Неверная команда.");
                }
            }
        }
    }
}