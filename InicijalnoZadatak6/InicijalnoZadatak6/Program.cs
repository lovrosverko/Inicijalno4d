using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoZadatak6
{
    interface IControl
    {
        void Metoda1();
        void Metoda2();
    }
    class RadioButton : IControl
    {
        public void Metoda1()
        {
            Console.WriteLine("Metoda1");
        }
        public void Metoda2()
        {
            Console.WriteLine("Metoda2");
        }
    }
    class CheckBox : IControl
    {
        public void Metoda1()
        {
            Console.WriteLine("Metoda1");
        }
        public void Metoda2()
        {
            Console.WriteLine("Metoda2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RadioButton x = new RadioButton();
            CheckBox y = new CheckBox();
        }
    }
}
