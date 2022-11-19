
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student_class
    {
        public string Name;
        public string LastName;
        public string Grup;
        public byte Point;
        public bool IsGraduated;

        public Student_class(string name, string nastName, string grup, byte point, bool isGraduated)
        {
            Name = name;

            LastName = nastName;
            Grup = grup;
            Point = point;
            IsGraduated = isGraduated;
            Console.WriteLine(name);
            Console.WriteLine(nastName);
            Console.WriteLine(grup);
            Console.WriteLine(point);
            Console.WriteLine(isGraduated);
            Graduated();
            Point1();

        }

        public void Graduated()
        {
            if (IsGraduated)
            {
                Console.WriteLine("Mezun olub");

            }
            else
            {
                Console.WriteLine("mezun olmayib");

            }
        }
        public void Point1()
        {
            if (Point > 80)
            {
                Console.WriteLine("Novbeti merheleye sans qazandiniz");

            }
            else
            {
                Console.WriteLine("Novebeti merheleye sans qazanmadiz");
            }
        }






    }
    }
