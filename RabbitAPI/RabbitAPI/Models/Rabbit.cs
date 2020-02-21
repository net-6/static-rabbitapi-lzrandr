using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAPI.Models
{
    public enum FurColors
        {
            White = 1 ,
            Brown = 2,
            Black = 3,
            Grey = 4
        }
        public enum EyeColors
        {
            Blue = 1,
            Black = 2,
            Red = 3
        }
        public enum Gender
        {
            Male =  1,
            Female = 2
        }
    public class Rabbit
    {
        
        public FurColors FurColors { get; set; }

        public EyeColors EyeColors { get; set; }

        public Gender Gender { get; set; }

        public  DateTime DateOfBirth { get; set; }

        public int Age
        {
            get { return (DateTime.Now - DateOfBirth).Days / 365; }
        }

        public Rabbit()
        {
        }

        public void Move()
        {
            Console.WriteLine("The rabbit is moving left and right like crazy.");
        }
        public void Sleep()
        {
            Console.WriteLine("The rabbit is sleeping like a rock.");
        }
        public void Eat()
        {
            Console.WriteLine("The rabbit is eating some food");
        }
        
    }
}
