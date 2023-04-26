using System;



namespace OopCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory vwFactory = new Factory("Volkswagon");
            Car beetle1 = vwFactory.createCar("Beetle", 50f);
            Car camper = vwFactory.createCar("Camper", 45f);

            TestCar(ref beetle1);
            TestCar(ref camper);

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


   


}