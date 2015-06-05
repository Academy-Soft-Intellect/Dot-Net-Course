using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Главен клас за стартиране на примерното приложение
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Главен метод за стартиране
        /// </summary>
        static void Main()
        {

            // Конструкторът е защитен -- операторът new не може да бъде извикан
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Проверка за идентичност на инстанцията
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance"); //и двата обекта са една и съща инстанция на този клас
            }
        }
    }

    /// <summary>
    /// The 'Singleton' class – класът Сек
    /// </summary>
    class Singleton
    {
        private static Singleton _instance;  //променлива за единствената инстанция на този клас
        // Конструторът е защитен и не може да бъде извикан
        protected Singleton()
        {

        }

        // Единтвеният начин за инстанцииране е от тук
        public static Singleton Instance()
        {
            // Използва късна инициализация (lazy initialization)
            // N.B.: Да не се използва в многонишкови приложения
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
 
}
