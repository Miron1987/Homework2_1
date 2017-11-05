using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    
    class Worker
    {
        

        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Payment { get; set; } //зарплата
        public decimal Useful { get; set; } //выработка
        public string Profession { get; set; }

        public Worker(string name, string surname, decimal payment, decimal useful, string profession)
    {
        Name = name;
        Surname = surname;
        Payment = payment;
        Useful = useful;
        Profession = profession;
    }
    
        public static List<Worker> GetSampleWorkers()
        {
            return new List<Worker>
            {
                new Worker(name : "Иван", surname : "Иванов", payment : 45000,
            useful : 155000, profession : "плотник"),
                new Worker(name : "Петр", surname : "Петров", payment : 55000,
            useful : 156000, profession : "бетонщик"),
                new Worker(name : "Сидор", surname : "Сидоров", payment : 50000,
            useful : 163000, profession : "сварщик"),
            };
        }


    }


    class Manager
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Payment { get; set; } //зарплата
        public decimal Useful { get; set; } //выработка
        public string Profession { get; set; }

        public Manager(string name, string surname, decimal payment, decimal useful, string profession)
        {
            Name = name;
            Surname = surname;
            Payment = payment;
            Useful = useful;
            Profession = profession;
        }

        public static List<Manager> GetSampleManagers()
        {
            return new List<Manager>
            {
                new Manager(name : "Сергей", surname : "Сергеев", payment : 35000,
            useful : 140000, profession : "менеджер по продажам"),
                new Manager(name : "Михаил", surname : "Михайлов", payment : 42000,
            useful : 158000, profession : "менеджер по рекламе"),
                new Manager(name : "Кирилл", surname : "Кириллов", payment : 65000,
            useful : 166000, profession : "менеджер по еще чему-то"),
            };
        }
    }

}

