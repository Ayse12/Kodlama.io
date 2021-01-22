using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Diyarbakır");
            sehirler.Add("Diyarbakır");

            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler1 = new MyList<string>();
            sehirler1.Add("Diyarbakır");
            sehirler1.Add("Diyarbakır");
            sehirler1.Add("Diyarbakır");
            sehirler1.Add("Diyarbakır");
            sehirler1.Add("Diyarbakır");
            Console.WriteLine(sehirler1.Count);
        }
    }
    //Proportie .name
    //Method .name()

    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;//temparrray arrayin referansını tutuyor.
            _array = new T[_array.Length + 1];//Eleman sayısını 1 arttırıyorum.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; //Geçici bellekteki adres _array'in elemanlarını geri getirir.

            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
