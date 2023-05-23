using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    internal class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public System.DateTime Date { get; set; }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "m" || value == "м" || value == "f" || value == "ж")
                {
                    gender = value;
                }
                else
                {
                    gender = "бесполый";
                }
            }
        }
        public void vivod()
        {
            Console.WriteLine($" {Lastname} {Name} {gender} пола Дата рождения:{Date}");
        }
        public void vvod()
        {
            Console.WriteLine("Введите имя:");
            Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            Lastname = Console.ReadLine();
            Console.WriteLine("Введите пол:");
            Gender = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            Date = Convert.ToDateTime(Console.ReadLine());
        }

        public override string ToString()
        {
            return Lastname + " " + Name[0] + ". " + Gender + " пола" + " Возраст:" + Vozrast();
        }

        public Person(string name, string lastname, DateTime date, string gender)
        {
            Name = name;
            Lastname = lastname;
            Date = date;
            Gender = gender;
        }
        public Person()
        {
            Name = "";
            Lastname = "";
            Gender = "";
            Date = System.DateTime.Now;
        }
        public Person(Person obj)
        {
            Name = obj.Name;
            Lastname = obj.Lastname;
            Gender = obj.Gender;
            Date = obj.Date;
        }
        public int Vozrast()
        {
            int vozr;
            System.DateTime data2=DateTime.Now;
            if (data2.Month < Date.Month)
            {
                vozr = data2.Year - Date.Year - 1;
            }
            else if (data2.Month > Date.Month)
            {
                vozr = data2.Year - Date.Year;
            }
            else
            {
                if (data2.Day >= Date.Day)
                {
                    vozr = data2.Year - Date.Year;
                }
                else
                {
                    vozr = data2.Year - Date.Year - 1;
                }
            }
            return vozr;
        }
    }
}
