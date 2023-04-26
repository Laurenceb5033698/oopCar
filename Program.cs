using System;



namespace OopCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dealership dealer = new();

            Factory vwFactory = new Factory("Volkswagon");
            dealer.addCar(vwFactory.createCar("Beetle", 50f));
            dealer.addCar(vwFactory.createCar("Camper", 45f));

            Factory bmwFactory = new Factory("BMW");
            dealer.addCar(bmwFactory.createCar("The 501", 60f));

            Factory toyFactory = new Factory("Toyota");
            dealer.addCar(toyFactory.createCar("Corolla", 70f));

            List<Car> vwcars = new List<Car>();
            dealer.FindByMaker("Volkswagon", ref vwcars);

            dealer.TestCar(vwcars[0]);


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