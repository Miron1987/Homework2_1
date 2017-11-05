using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = 0;
            decimal money = 0;

            List<Worker> workers = Worker.GetSampleWorkers();
            List<Manager> managers = Manager.GetSampleManagers();


            var _workers = from worker in workers
                           select worker.Payment;

            var _managers = from manager in managers
                            select manager.Payment;


            foreach (var wor in _workers)
            {
                people += 1;
                money += wor;
            }

            foreach (var manag in _managers)
            {
                people += 1;
                money += manag;
            }

            Console.WriteLine($"Работников: {people}, Средняя зарплата: {Decimal.Round(money / people, 2)} руб.");

            var best_wor = from _worker in workers
                           where _worker.Useful == BestOfWorkers(workers)
                           select _worker;

            foreach (var _best in best_wor)
            {
                Console.WriteLine($"Лучший работник: {_best.Name} {_best.Surname}, {_best.Profession}");
            }


            var best_man = from _manager in managers
                           where _manager.Useful == BestOfManagers(managers)
                           select _manager;

            foreach (var _best in best_man)
            {
                Console.WriteLine($"Лучший манагер: {_best.Name} {_best.Surname}, {_best.Profession}");
            }
        }


        static decimal BestOfWorkers(List<Worker> list)
        {
            int i = 0;
            decimal best;
            decimal[] useful = new decimal[list.Count];

            var best_worker = from worker in list
                              select worker.Useful;

            foreach (decimal num in best_worker)
            {
                useful[i] = num;
            }

            best = useful.Max();

            return best;
        }


        static decimal BestOfManagers(List<Manager> list)
        {
            int i = 0;
            decimal best;
            decimal[] useful = new decimal[list.Count];

            var best_manager = from worker in list
                              select worker.Useful;

            foreach (decimal num in best_manager)
            {
                useful[i] = num;
            }

            best = useful.Max();

            return best;
        }






    }


}
