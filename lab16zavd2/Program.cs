using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16zavd2
{
    class Program
    {
        struct PIP
        {
            public string fname;
            public string sname;
            public string father;
            public void Info()
            {
                Console.WriteLine($"Імя: {fname}  Фамілія: {sname}  Побатькові: {father}");
            }

            public  PIP (string f, string s, string fa)
            {
                this.fname = f;
                this.sname = s;
                this.father = fa;
            }

            public PIP(bool vib):this()
            {
                if (vib)
                {
                    Console.Write("Введіть імя: ");
                    this.fname = Console.ReadLine();
                    Console.Write("Введіть фамілію: ");
                    this.sname = Console.ReadLine();
                    Console.Write("Введіть побатькові: ");
                    this.father = Console.ReadLine();
                }
            }

        }

        static void Main(string[] args)
        {
            string posh;
            PIP[] arr = new PIP[]
            {
                new PIP("Богдан","Стицун","Андрійович"),
                new PIP("Вадим","Лебедюк","Федорович"),
                new PIP(true),
            };

            Console.WriteLine("Вся база:");
            foreach (PIP n in arr)
                n.Info();

            Console.Write("Кого знайти: ");
            posh = Console.ReadLine();

            int index = -1;

            for (int i = 0; i < arr.Count(); i++)
                if (arr[i].sname == posh) index = i;

            if (index == -1)
                Console.WriteLine($"Нічого не знайдено на {posh}");
            
            else
            {
                Console.WriteLine($"Ось що знайдено на {posh}:");
                arr[index].Info();
            }

            
            Console.ReadLine();
        }
    }
}

