using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class power
    {
        public void PowerOn(bool ison)
        {
            bool isOn = true;
            Console.WriteLine("Кофемашина включена");
        }

        public void PowerOff(bool ison)
        {
            bool isOn = false;
            Console.WriteLine("Кофемашина выключена!");
        }
    }
   
}
