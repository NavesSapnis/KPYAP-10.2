using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KPYAP_10._2
{
    internal class ArrayOfCars :IInput, ICloneable, IComparable
    {
        private HeavyCar[] cars;

        public ArrayOfCars(HeavyCar[] cars)
        {
            this.cars = cars;
        }
        public ArrayOfCars()
        {
            
        }
        public ArrayOfCars CreateGarage()
        {
            string[] arrayOfNames = { "Mercedes Benz", "Man", "Daf", "Scania", "Volvo"};
            Random random = new Random();
            HeavyCar[] cars = new HeavyCar[5];
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new HeavyCar(arrayOfNames[random.Next(0, 4)], random.Next(1, 29), random.Next(1, 999), random.Next(1, 1000));
            }
            ArrayOfCars ArrOfCars = new ArrayOfCars(cars);
            return ArrOfCars;
        }
        public void PrintCars()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i] + "\n\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            }
        }
        public HeavyCar MaxCarByPower()
        {
            int max = cars[0].upPower;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].upPower > max)
                {
                    max = cars[i].upPower;
                }
            }
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].upPower == max)
                {
                    return cars[i];
                }
            }
            return cars[0];
        }
        public object Input()
        {
            Console.WriteLine("Введите размерность");
            int num = Convert.ToInt32(Console.ReadLine());
            HeavyCar[] heavyCars= new HeavyCar[num];
            for (int i = 0; i < heavyCars.Length; i++)
            {
                heavyCars[i].Input();
            }
            return new ArrayOfCars(heavyCars);
        }
        public object Clone()
        {
            return new ArrayOfCars(cars);
        }
        public int CompareTo(object obj)
        {
            ArrayOfCars temp = (ArrayOfCars)obj;
            return Math.Sign(this.cars.Length - temp.cars.Length);//На кол-во элементов в массиве
        }
    }
}
