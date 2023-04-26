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

            Factory bmwFactory = new Factory("BMW");
            Car the501 = bmwFactory.createCar("The 501", 60f);

            TestCar(ref beetle1);
            TestCar(ref camper);
            TestCar(ref the501);

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
            car.Decelerate(car.topSpeed);
            car.StopEngine();
        }
    }
}