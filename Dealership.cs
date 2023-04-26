namespace OopCar
{
    public class Dealership
    {
        List<Car> stock;
        public Dealership()
        {
            stock = new List<Car>();
        }

        public void addCar(Car _car)
        {
            stock.Add(_car);
        }

        public void removeCar(ref Car _car)
        {
            stock.Remove(_car);
        }

        public void FindByMaker(string _maker, ref List<Car> outList)
        {
            foreach(Car val in stock)
            {
                if(val.maker == _maker)
                {
                    outList.Add(val);
                }
            }
        }

        public void TestCar(Car car)
        {
            TestDrive drive = new TestDrive(ref car);
            drive.Drive();

        }



    }
}