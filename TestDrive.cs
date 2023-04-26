namespace OopCar
{
    public class TestDrive
    {
        Car car;
        bool driving;

        enum Action
        {
            NONE,
            START,
            STOP,
            ACCEL,
            DECEL,
            EXIT,
            NUMACTIONS
        };
        public TestDrive(ref Car _car)
        {
            car = _car;
            driving = true;
        }

        public void Drive()
        {
            driving = true;
            while (driving)
            {
                TakeInstruction();

            }
        }
        private Action Input( out int speed)
        {
            string rawInput = Console.ReadLine() ?? "";
            string[] words = rawInput.Split(' ');
            string action = "";
            string value = "";
            speed = 0;
            action = words[0];
            if(words.Length > 1)
            {
                value = words[1];
                speed = int.Parse(value);
            }

            return ParseInput(action);
        }

        private Action ParseInput(string input) => input switch
        {
            ""      => Action.NONE,
            "exit"  => Action.EXIT,
            "accel" => Action.ACCEL,
            "decel" => Action.DECEL,
            "start" => Action.START,
            "stop"  => Action.STOP,
            _       => Action.NONE,
        };

        private void TakeInstruction()
        {
            int speed = 0;
            DoAction(Input(out speed), speed);

        }
        private void DoAction(Action action, int value)
        {
            switch (action)
            {
                case Action.NONE:   Empty();            break;
                case Action.EXIT:   EndDrive();         break;
                case Action.START:  car.StartEngine();  break;
                case Action.STOP:   car.StopEngine();   break;
                case Action.ACCEL:  car.Accelerate(value);   break;
                case Action.DECEL:  car.Decelerate(value);   break;              
                default: Empty(); break;
            }

        }

        private void Empty()
        {
            return;
        }


        private void EndDrive()
        {
            driving = false;

        }

    }


}