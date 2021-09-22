using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Program
    {
        // Client Class or User Class
        static void Main(string[] args)
        {
            // Get Object from static Method Call
            DisplayData obj = DisplayData.GetObject();
            obj.GetData();
            Console.ReadLine();
        }
    }

    public sealed class DisplayData // Sealed Class
    {
        private DisplayData() // Private & Parameter less Constructor
        {

        }

        public static DisplayData classInstance = null; // Static variable

        public static DisplayData GetObject() // Static Class to Return Object
        {
            if (classInstance == null)
            {
                return new DisplayData();
            }
            return classInstance;

        }

        public void GetData()
        {
            Console.WriteLine(" This is Data");
        }
    }
}
