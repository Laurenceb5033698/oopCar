
namespace OopCar
{
    public class Car
    {
        private void Print(string str)
        {
            Console.WriteLine(str);
        }
        bool engineRunninng;
        public string maker {get; private set;}
        public string model {get; private set;}
        public float currentSpeed {get; private set;}
        public float topSpeed {get; private set;}
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
            Print(model + " turned engine on.");
        }

        public void StopEngine()
        {
            engineRunninng = false;
            Print(model + " turned engine off.");
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