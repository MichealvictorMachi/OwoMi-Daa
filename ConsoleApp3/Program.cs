namespace ConsoleApp3
{
    internal class Owomida
    {
        public int towRate(int x)
        {
            int output;
            switch (x)
            {
                case 1:
                    output = 500;
                    break;
                case 2:
                    output = 300;
                    break;
                case 3:
                    output = 200;
                    break;

                default:
                    output = 100;
                    break;
            }
            return output;



        }
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i <= 4; i++)
               
            {


                Console.WriteLine("Welcome to Owo Mi Daa");
                Console.WriteLine("Are you a registered Driver? (Type 'yes or no')");
                string status = Console.ReadLine();
                string statuss = status.ToLower();
                Console.WriteLine("Vehicle type? (1) Bus (2) Shuttle (3) Tricycle (4) Motorcycle");
                int vehicle = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of trips: ");
                int num = Convert.ToInt32(Console.ReadLine());
                var prog = new Owomida();
                int amount = prog.towRate(vehicle);
                if (statuss == "yes")
                {
                    Console.WriteLine("Your bill is " + num * (amount * 0.7f));
                }
                else
                {
                    Console.WriteLine("Your bill is " + num * (amount));
                }

                total = total + amount; 
                
            }
            Console.WriteLine("Total  amount is "+ total);
        }
    }
}