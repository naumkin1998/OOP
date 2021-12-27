using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surtname;

        /// <summary>
        /// Возвраст
        /// </summary>
        private int _age;

        /// <summary>
        /// Пол
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        public Person(Gender gender, string name, string surname, int age)
        {
            _gender = gender;
            _name = name;
            _surtname = surname;
            _age = age;
        }
    }
}
