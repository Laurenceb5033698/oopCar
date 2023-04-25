using System;



namespace OopCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory vwFactory = new Factory("Volkswagon");
            Car beetle1 = vwFactory.createCar("Beetle", 50f);

            TestCar(ref beetle1);

        }

        static void TestCar(ref Car car)
        {
            car.Accelerate(10f);
            car.StartEngine();
            car.Accelerate(12f);
            car.Accelerate(5f);
            car.StopEngine();
            car.Decelerate(20f);
            car.Accelerate(5f);
            car.StartEngine();
            car.Accelerate(50f);
            car.Accelerate(10f);
            car.Decelerate(50f);
            car.StopEngine();
        }
    }


    public class Factory
    {
        string maker;
        public Factory(string _maker)
        {
            maker = _maker;
        }

        public Car createCar(string model, float topSpeed)
        {
            return new Car(maker, model, topSpeed);
        }
    }


    public class Car
    {
        private void Print(string str)
        {
            Console.WriteLine(str);
        }
        string maker;
        string model;
        float currentSpeed;
        float topSpeed;
        bool engineRunninng;
        public Car(string _maker, string _model, float _topSpeed)
        {
            maker = _maker;
            model = _model;
            topSpeed = _topSpeed;
            currentSpeed = 0f;
            engineRunninng = false;
        }

        public void StartEngine()
        {
            engineRunninng = true;
            Print("The engine is Running.");
        }

        public void StopEngine()
        {
            engineRunninng = false;
            Print("The Engine is off.");
        }

        public void Accelerate(float amount)
        {
            if (!checkEngine())
            {
                Print("The Engine is not running!");
                return;
            }
            if (currentSpeed + amount < topSpeed)
                currentSpeed += amount;
            else
                currentSpeed = topSpeed;
            Print(model + " speed is " + currentSpeed);
        }

        public void Decelerate(float amount)
        {
            if (currentSpeed - amount > 0)
                currentSpeed -= amount;
            else
                currentSpeed = 0;
            Print(model + " speed is " + currentSpeed);
        }

        private bool checkEngine()
        {
            return engineRunninng;
        }


    }



}