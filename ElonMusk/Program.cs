namespace ElonMusk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //makes the cars
            car blackCar = new car();
            car whiteCar = new car();
            
            //defines the car to be a color
            blackCar.Color = "sort";
            whiteCar.Color = "hvid";

            //defines how long the car drives on 1 percent
            blackCar.MetersPerPercent = 20;
            whiteCar.MetersPerPercent = 20;
            
            //User chooses how many percent the car uses
            Console.WriteLine("vælg hvor mange procent den sorte bil skal bruge");
            blackCar.Distance = int.Parse(Console.ReadLine());

            Console.WriteLine("Vælg hvor mange procent den hvide bil skal bruge");
            whiteCar.Distance = int.Parse(Console.ReadLine());

            //Uses the method for the car
            blackCar.Drive();
            whiteCar.Drive();
        }
        public class car
        {
            //The instance variables
            private byte power = 100;
            private int distance;
            private string color;
            private int distanceDriven = 0;
            private int metersPerPercent;

            //Our incapsulation of the instance variables
            public byte Power
            {
                get { return power; }
                set { power = value; }
            }
            public int Distance
            {
                get { return distance; }
                set { distance = value; }
            }
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
            public int DistanceDriven
            {
                get { return distanceDriven; }
                set { distanceDriven = value; }
            }
            public int MetersPerPercent
            {
                get { return metersPerPercent; }
                set { metersPerPercent = value; }
            }

            //The method we use to make the car drive
            public void Drive()
            {
                //checks if the power on the battery is above 0
                if (power > 0)
                {
                    //Loops the code the amount of times the user told it to
                    for (int i = 0; i < distance; i++)
                    {
                        if (power > 0)
                        {
                            //Minuses 1 from the battery
                            power--;
                            //adds 20 meters to distanceDriven
                            distanceDriven += 20;                            
                        }
                    }
                    //Writes how much power is left, and how long the car has driven
                    Console.WriteLine($"{Color} bil har {power}% strøm");
                    Console.WriteLine($"{color} bil har kørt {distanceDriven} Meter\r\n");
                }
                //Tells the user if there is no more power left on the battery
                else
                {
                    Console.WriteLine("Der er ikke mere strøm på din bil");
                }
            }
            
        }
        
    }
}