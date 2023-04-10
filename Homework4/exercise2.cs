using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class exercise2
    {
        public void IfVowel()
        {
            Console.WriteLine("Enter a letter: ");
            char ch = Convert.ToChar(Console.ReadLine());
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The letter is a vowel!");
                        break;


                    case 'e':
                        Console.WriteLine("The letter is a vowel!");
                        break;

                    case 'i':
                        Console.WriteLine("The letter is a vowel!");
                        break;

                    case 'o':
                        Console.WriteLine("The letter is a vowel!");
                        break;

                    case 'u':
                        Console.WriteLine("The letter is a vowel!");
                        break;
                        default: Console.WriteLine("The letter is a consonant"); break;
                }
                Console.ReadKey();

                
            
                    
            }
        }

        
    }
}
