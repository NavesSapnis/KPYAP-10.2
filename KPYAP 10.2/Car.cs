using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPYAP_10._2
{
    internal class Car : IComparable, IComparer<Car>, ICloneable, IInput,ICreate
    {
        protected static Random ran = new Random();
        protected string name;
        protected int cil;
        protected int power;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Cil
        {
            get { return cil; }
            set
            {
                if (value < 0 || value > 20)
                {
                    cil = 0;
                }
                else
                {
                    cil = value;
                }
            }
        }
        public int Power
        {
            get { return power; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    power = 0;
                }
                else
                {
                    power = value;
                }
            }
        }
        public Car(string name, int cil, int power)
        {
            Name = name;
            Cil = cil;
            Power = power;
        }
        public Car() { }
        public override string ToString()
        {
            return "Марка = " + name + "\nКол-во цилиндров = " + cil + "\nМощность = " + power;
        }
        public object Create()
        {
            string[] name = { "Audi", "Acura", "Alfa Romeo", "Aston Martin", "Bentley", "BMW", "Toyota" };
            Car car = new Car(name[ran.Next(0, 7)], ran.Next(1, 21), ran.Next(1, 1000));
            return car;
        }
        public Car[] RandomCar()
        {
            Car[] cars = new Car[5];
            Car temp = new Car();
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = (Car)temp.Create();
            }
            return cars;
        }
        public int CompareTo(object obj)
        {
            Car temp = (Car)obj;
            return Math.Sign(this.Power - temp.Power);//vor next sorting by "Кол-во лош. сил"
        }

        public int Compare(Car p1, Car p2)
        {
            return p1.Cil - p2.Cil;//vor next sorting by "Кол-во цилиндров"
        }
        public object Clone()
        {
            return new Car(Name, Cil, Power);
        }
        public object Input()
        {
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            Console.WriteLine("Введите кол-во цилиндров");
            int cil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во лошадиных сил");
            int power = Convert.ToInt32(Console.ReadLine());
            return new Car(Name = name, Cil = cil, Power = power);
        }
    }
}
