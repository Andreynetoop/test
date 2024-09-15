using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    
    public class StatusMachine
        {
           public void Check()
        {
            Console.WriteLine("Запустить машину?Нажмите Y или N");
            string startstop = Console.ReadLine();
            int check;
            if(startstop == "Y")
            {
                bool on = true;
                power start = new power();
                start.PowerOn(on);
                CheckCoffe test = new CheckCoffe();
                MainMeny ismeny = new MainMeny();
                ismeny.meny();

            }
            else if(startstop == "N")
            {
                bool off = false;
                power stop = new power();
                stop.PowerOff(off);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка!Неверная команда.");
                Console.ReadKey();
            }
            
        }
        }


    class Program
    {
        static void Main(string[] args)
        {
            StatusMachine check = new StatusMachine();
            check.Check();
            
            
        }
    }




}
  

        
      


