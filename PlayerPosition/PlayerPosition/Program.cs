using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPosition
{
    internal class Program
    {
        public int position = 0;
        

        public void Player1()
        {
            Console.WriteLine("single player position : " + position);
        }

        static void Main(string[] args)
        {
            int position = 0;

            Console.WriteLine("single player position : " + position);
            Console.Read();
        }
    }
}
