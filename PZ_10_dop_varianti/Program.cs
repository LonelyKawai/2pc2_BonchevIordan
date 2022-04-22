using System;
//вы сказали скинуть его вам чтобы посмоторели потому что первая итерация цикла проходит нормально а как начинается вторая появляется ошибка
namespace PZ_10_dop_varianti
{
    using System;

    namespace ConsoleApp6
    {
        struct WORKER
        {
            public string NAME;
            public string POS;
            public int YEAR;
            public int experience;
        }

        class Program
        {
            public static int year_now;
            static WORKER[] TABL = new WORKER[3];
            static void input()
            {
                for (int i = 0; i < TABL.Length; i++)
                {
                    Console.WriteLine("Введите какой сейчас год: ");
                    year_now = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите данные {0} работника", i++);
                    Console.WriteLine("Фамилия и инициалы");
                    TABL[i].NAME = Console.ReadLine();
                    Console.WriteLine("название занимаемой должности");
                    TABL[i].POS = Console.ReadLine();
                    Console.WriteLine("Год поступления на работу");
                    TABL[i].YEAR = Convert.ToInt32(Console.ReadLine());
                    TABL[i].experience = year_now - TABL[i].YEAR;
                }
            }
            static void sort_array()
            {
                Array.Sort(TABL);
                Console.WriteLine(string.Join(" ", TABL));
            }
            static void sort_experience()
            {
                int a = 0;
                int min_experience;
                Console.WriteLine("Введите минимальный стаж работы сотрудника: ");
                min_experience = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < TABL.Length; i++)
                {
                    Console.WriteLine("Сотрудники со стажем от {0} лет: ", min_experience);
                    TABL[i].experience = year_now - TABL[i].YEAR;
                    if (TABL[i].experience >= min_experience)
                    {
                        Console.WriteLine(TABL[i].NAME);
                        a++;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine("Работников имеющих стаж {0}, не найдено: ", min_experience);
                }
            }
            static void Main(string[] args)
            {
                input();
                //sort_array();
                sort_experience();
            }
        }
    }
}
