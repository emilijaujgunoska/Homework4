using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class exercise3
    {

        public void Grade()
        {
            Console.WriteLine("Wrtie a grade from A to F (Capital letters): ");
            char grade = Convert.ToChar(Console.ReadLine());

            switch (grade) 
            {
            case 'A':
                    Console.WriteLine("5"); break;
            case 'B':
                    Console.WriteLine("4"); break;
            case 'C':
                    Console.WriteLine("3"); break;
            case 'D':
                    Console.WriteLine("2"); break;
            case 'F':
                    Console.WriteLine("1"); break;

                    default: Console.WriteLine(" error ");break;
            }
            Console.ReadLine();
        
        } 
    }
}
