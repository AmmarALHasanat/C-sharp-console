using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning
{
    internal class Car
    {
        private string name;
        public Car()
        {
            name = "";
        }
        public Car(string var)
        {
            name = var;
        }

        public string getName() {
            return name;
         }
        public void setName(string var)
        {
            name = var;
        }
    }
}
