using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CheckCoffe
    {
        static  int sugar = 2000;
        static  int water = 2000;
        static  int milk = 1000;
        static  int coffe = 3000;

        public void MakeCappuccino()
        {
            if (sugar < 400)
            {
                Console.WriteLine("Не хватает сахара! Осталось: " + sugar);
                return; // Прерываем выполнение метода
            }
            if (water < 1000)
            {
                Console.WriteLine("Не хватает воды! Осталось: " + water);
                return; // Прерываем выполнение метода
            }
            if (milk < 400)
            {
                Console.WriteLine("Не хватает молока! Осталось: " + milk);
                return; // Прерываем выполнение метода
            }
            if (coffe < 400)
            {
                Console.WriteLine("Не хватает кофейных зёрен! Осталось: " + coffe);
                return; // Прерываем выполнение метода
            }

            // Если все проверки пройдены, уменьшаем количество ингредиентов
            sugar -= 400;
            water -= 1000;
            milk -= 400;
            coffe -= 400;

            Console.WriteLine("Капучино готовится...");
            Console.WriteLine("Готово! Осталось: Сахар - " + sugar + ", Вода - " + water + ", Молоко - " + milk + ", Кофе - " + coffe);
            Console.WriteLine("Нажмите для завершения и можете забирать.");
            Console.ReadKey();
        }

        public void MakeEspresso()
        {
            if (sugar < 600)
            {
                Console.WriteLine("Не хватает сахара! Осталось: " + sugar);
                return; // Прерываем выполнение метода
            }
            if (water < 800)
            {
                Console.WriteLine("Не хватает воды! Осталось: " + water);
                return; // Прерываем выполнение метода
            }
            if (coffe < 800)
            {
                Console.WriteLine("Не хватает кофейных зёрен! Осталось: " + coffe);
                return; // Прерываем выполнение метода
            }

            // Если все проверки пройдены, уменьшаем количество ингредиентов
            sugar -= 600;
            water -= 800;
            coffe -= 800;

            Console.WriteLine("Эспрессо готовится...");
            Console.WriteLine("Нажмите для завершения и можете забирать.");
            Console.ReadKey();
        }
        public void resouces()
        {
            Console.WriteLine("Осталось: Сахар - " + sugar + ", Вода - " + water + ", Молоко - " + milk + ", Кофе - " + coffe);
            Console.ReadKey();
        }
        public void AddWater()
        {
            Console.WriteLine("Введите количество воды,которое хотите добавить: ");
            int add = Convert.ToInt32(Console.ReadLine());
            water += add;
            if(water > 2000)
            {
                water -= add;
                Console.WriteLine("Невозможно добавить столько воды!Максимальный уровень не более 2000ед.");
                CheckCoffe meny = new CheckCoffe();
                meny.AddWater();
            }
            else
            {
                Console.WriteLine($"Отлично!Пополнили на {add}ед.");
            }

        }
        public void AddSugar()
        {
            Console.WriteLine("Введите количество сахара,которое хотите добавить: ");
            int addsugar = Convert.ToInt32(Console.ReadLine());
            sugar += addsugar;
            if (sugar > 2000)
            {
                sugar -= addsugar;
                Console.WriteLine("Невозможно добавить столько сахара!Максимальный уровень не более 2000ед.");
                CheckCoffe meny = new CheckCoffe();
                meny.AddWater();
            }
            else
            {
                Console.WriteLine($"Отлично!Пополнили на {addsugar}ед.");
            }
        }

    }
}
