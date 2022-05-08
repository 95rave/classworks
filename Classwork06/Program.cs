using System;

namespace Classwork06
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun colt911 = new Gun("colt911", 100, 6);
            while (true)
            {
                Console.WriteLine("Select Action\n1 - Shoot\n2 - Reload\n3 - Info\n");
                byte selection = Convert.ToByte(Console.ReadLine());
                switch (selection)
                {
                    case (byte)Actions.Shoot:
                        colt911.Shoot();
                        break;

                    case (byte)Actions.Reload:
                        colt911.Reload();
                        break;
                    case (byte)Actions.Info:
                        Console.WriteLine(colt911.GetInfo());
                        break;
                    default:
                        Console.WriteLine("Please select the correct operation");
                        break;

                }
                Console.WriteLine("\n");
            }
            
        }
    }
}
