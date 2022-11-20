using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KPYAP_10._2
{
    internal class Program
    {
        public static int Menu(string text)
        {
            Console.WriteLine(text);
            int ret = Convert.ToInt32(Console.ReadLine());
            return ret;
        }
        static void Main(string[] args)
        {
            Car[] cars = new Car[5]; Car temp = new Car();
            HeavyCar[] heavyCars = new HeavyCar[5]; HeavyCar tempHeavy = new HeavyCar();
            Car test1 = new Car("ds",10,222);
            Car test2 = new Car("ds", 10, 222);
            ArrayOfCars garage = new ArrayOfCars();
            while (true)
            {
                try
                {
                    switch (Menu("Выберите пункт меню\n1 - Создать массив машин\n2 - Вывести все машины \n3 - Вывести машину с самой большой грузоподъемностью\n\nЛАБА 11.2\n4 - Создать машину\n5 - Клонировать машину\n6 - Создать массив машин\n7 - Отсортировать\n8 - Вывести массив"))
                    {
                        case 1:
                            Console.Clear();
                            garage = garage.CreateGarage();
                            Console.WriteLine("Создано !");
                            break;
                        case 2:
                            Console.Clear();
                            garage.PrintCars();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(garage.MaxCarByPower());
                            break;
                        case 4:
                            Console.Clear();
                            temp.Input();
                            Console.WriteLine(temp);
                            break;
                        case 5:
                            Console.Clear();
                            temp.Clone();
                            Car fakeCar = new Car();
                            fakeCar = (Car)temp.Clone();
                            Console.WriteLine("Копия :\n" + fakeCar + "\n");
                            break;
                        case 6:
                            Console.Clear();
                            //cars = temp.RandomCar();
                            //heavyCars = tempHeavy.RandomCar();
                            test1 = (Car)test1.Create();
                            test2 = (Car)test2.Create();
                            Console.WriteLine(test1+"\n"+test2);
                            Console.WriteLine("Создано !");
                            break;
                        case 7:
                            Console.Clear();
                            switch (Menu("1 - отсортировать обычные машины по мощности\n2 - отсортировать грузовые машины по грузоподъемности"))
                            {
                                case 1:
                                    Console.Clear();
                                    Array.Sort(cars);//Сортировка по мощности
                                    break;
                                case 2:
                                    Console.Clear();
                                    Array.Sort(heavyCars, new HeavyCar());//Сортировка больших машин по грузоподъмности
                                    break;
                            }
                            break;
                        case 8:
                            Console.Clear();
                            switch(Menu("1 - обычных машин\n2 - грузовых машин"))
                            {
                                case 1:
                                    for (int i = 0; i < cars.Length; i++)
                                    {
                                        Console.WriteLine(cars[i]);
                                        Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - -");
                                    }
                                    break;
                                case 2:
                                    for (int i = 0; i < heavyCars.Length; i++)
                                    {
                                        Console.WriteLine(heavyCars[i]);
                                        Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - -");
                                    }
                                    break;
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Вы ввели неверное/недосягаемое значение");
                }


            }
        }
    }
}
