using System;

namespace Interfaces1
{
    class Program
    {
        //İnterface new'lenemez.
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            Console.WriteLine("----------------");

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());

        }
    }
    //İnherits Class
    class PersonManager
    {
        //Tamamlanmış operasyon(içi doldurulmuş)
        //Implemented Operation
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
        //Her yerde ortak olur Kalıtım
    }
    interface IPersonManager
    {
        //Unimplemented operation
        //İmzam aynı olabilir ama müşteri için ekleme ayrı personel için ekleme ayrı olur. (içindeki kodlar)
        void Add();
        void Update();
        void Delete();
    }

    class CustomerManager : IPersonManager
    {
        //Müşteri ekleme kodları
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");

        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Empleyee Added");
        }

        public void Delete()
        {
            Console.WriteLine("Empleyee Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Empleyee Updated");

        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added");
        }

        public void Delete()
        {
            Console.WriteLine("Intern Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
