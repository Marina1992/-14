using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
	• абстрактное свойство - название животного.
     В классе Animal нужно определить следующие методы:
	• конструктор, устанавливающий значение по умолчанию для названия;
	• абстрактный метод Say(), который выводит звук, который издает животное;
	• неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
    Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
	• свойство – название животного;
	• метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
      Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.           
              
             */

            Cat cat = new Cat("Мурка");
            cat.ShowInfoy();

            Dog dog = new Dog("Шарик");

            dog.ShowInfoy();

            Console.ReadKey();

        }

            }

    public abstract class Animal
    {
       

        public string Name { get; set; }

        public Animal(string name )
        {
            Name = name;
            
        }

        public abstract void Say();
        public void ShowInfoy()  
        {

            Console.WriteLine("Меня зовут {0} " , Name);

            Say();
        }


    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        { }




        public override void Say()
        {
            Console.WriteLine("Мяу!");
        }
        

        
    }

    public class Dog: Animal
    {
        public Dog(string name) : base(name)
        { }




        public override void Say()
        {
            Console.WriteLine("Гав!");
        }



    }



}
