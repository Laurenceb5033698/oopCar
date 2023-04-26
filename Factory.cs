namespace OopCar
{
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