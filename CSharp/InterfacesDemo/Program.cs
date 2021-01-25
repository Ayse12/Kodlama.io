using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Worker(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();  
            }
        }
    }
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary(); //Maaş alır.
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Yer");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Maaş Alır");

        }

        public void Work()
        {
            Console.WriteLine("Manager Çalıştı");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Yer");

        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Maaş Alır");
        }

        public void Work()
        {
            Console.WriteLine("Worker Çalıştı");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalıştı");
        }
    }
}
