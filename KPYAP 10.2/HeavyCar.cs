using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPYAP_10._2
{
    internal class HeavyCar : Car
    {
        public int upPower;
        public int UpPower 
        { 
            get { return upPower; }
            set 
            {
                if (value < 0 || value > 10)
                {
                    upPower = 0;
                }

                else
                {
                    upPower = value;
                }
            }
        }

        public HeavyCar(string name,int cil,int power,int upPower):base(name,cil,power)
        {
            this.upPower = upPower;
        }
        public HeavyCar()
        {
            name = "Test-auto";
            cil = 12;
            power = 97;
            upPower = 300;
        }
        public override string ToString()
        {
            return "Марка = " + name + "\nКол-во цилиндров = " + cil + "\nМощность = " + power+ "\nГрузоподъемность кузова = "+upPower;
        }
        public new int CompareTo(object obj)
        {
            HeavyCar temp = (HeavyCar)obj;
            return Math.Sign(this.UpPower - temp.UpPower);
        }
        public int Compare(HeavyCar p1, HeavyCar p2)
        {
            return p1.Cil - p2.Cil;
        }
        public new object Clone()
        {
            return new HeavyCar(Name, Cil, Power,UpPower);
        }
        public new object Input()
        {
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            Console.WriteLine("Введите кол-во цилиндров");
            int cil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во лошадиных сил");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите гузоподъемность (в тоннах)");
            int upPower = Convert.ToInt32(Console.ReadLine());
            return new HeavyCar(Name = name, Cil = cil, Power = power,UpPower = upPower);
        }
        public new object Create()
        {
            Random random = new Random();
            string[] name = { "Audi", "Acura", "Alfa Romeo", "Aston Martin", "Bentley", "BMW", "Toyota" };
            HeavyCar car = new HeavyCar(name[random.Next(0, 7)], random.Next(1, 21), random.Next(1, 1000), random.Next(1, 10));
            return car;
        }
        public new HeavyCar[] RandomCar()
        {
            HeavyCar[] cars = new HeavyCar[5];
            HeavyCar temp = new HeavyCar();
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = (HeavyCar)temp.Create();
            }
            return cars;
        }
    }
}
