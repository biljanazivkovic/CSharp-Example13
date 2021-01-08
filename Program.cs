using System;

namespace ex13
{
    /*
    class Car
    {
        public string model;

        public Car()
        {
            model = "Mustang";
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }
    }
    */
    class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "red", 1969);
            Car Opel = new Car("Astra", "white", 2005);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            Console.WriteLine(Opel.color + " " + Opel.year + " " + Opel.model);
        }
    }
}
