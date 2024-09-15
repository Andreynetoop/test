using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class MainMeny
    {

        public void meny()
        {
            Console.WriteLine("Выберите кофе:");
            Console.WriteLine("1.Капучино \n2.Экспрессо \n3.Сделать кофе по моему рецепту\n4.Проверить уровни воды,кофе,сахара.\n5.Добавить воды.\n6.Добавить сахара\n7.Добавить кофе.\n8Добавить профиль.\n9.Мой профиль\n10.Проверка/Чистка машины.\n--------------------------");
            int chose = Convert.ToInt16(Console.ReadLine());

            switch (chose)
            {
                case 1:
                    CheckCoffe iscapusino = new CheckCoffe();
                    iscapusino.MakeCappuccino();
                    MainMeny ismeny = new MainMeny();                  
                    Console.WriteLine("Нажмите 0,чтобы вернуться в меню.Если желаете выключить кофемашину,нажмите 1");
                    int mainmeny = Convert.ToInt32(Console.ReadLine());
                    if(mainmeny == 0)
                    {
                        ismeny.meny();
                    }
                    else if(mainmeny == 1)
                    {
                        power off = new power();
                        off.PowerOff(false);
                    }
                    
                    break;
                case 2:
                    CheckCoffe isespresso = new CheckCoffe();
                    isespresso.MakeEspresso();
                    MainMeny newmeny = new MainMeny();
                    newmeny.meny();
                    break;
                case 3:
                    Console.WriteLine("Как назовём ваш кофе?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Отлмчно!Теперь введите количество кофе,сахара,молока и воды(вводите именно в таком порядке)");
                    int kofe = Convert.ToInt32(Console.ReadLine());
                    int saxar = Convert.ToInt32(Console.ReadLine());
                    int moloko = Convert.ToInt32(Console.ReadLine());
                    int woda = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ожидайте.Ваш {name} готовится!\n ----------------------------");
                    Thread.Sleep(5000);
                    Console.WriteLine($"Ваш {name} готов");
                    Console.ReadKey();
                    break;
                case 4:
                    CheckCoffe res = new CheckCoffe();
                    res.resouces();
                    break;
                case 5:

                    break;


            }



        }
    }
}
