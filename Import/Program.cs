using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title (will be centered)
            string title = "Imports (Basic)";
            Console.WriteLine(title.ToUpper());        
                     
            //To be assigned as a button on the web app
            Console.Write("Is this for Trade or Private client? ");
            string answer = Convert.ToString(Console.ReadLine());


            if (answer.Equals("trade"))
            {
                Console.WriteLine("Your Customs Clearance charges will be $245.00.");
                Console.ReadLine();
                Console.WriteLine("Your Terminal Fees will be $75.00");
                Console.ReadLine();

                //Crate Dimensions Entered
                Console.WriteLine("Please enter the crate Length for your incoming shipment: ");
                double l = new double();
                l = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the crate Width for your incoming shipment: ");
                double w = new double();
                w = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the crate Height for your incoming shipmet");
                double h = new double();
                h = double.Parse(Console.ReadLine());

                double totalDims = new double();
                totalDims = l * w * h;
                double volKg = new double();
                volKg = totalDims / 366;

                Console.WriteLine("Your total Vol Kg is {0:0.00}", +volKg);
                Console.ReadLine();

                Console.Write("Are there any additional crates? ");
                Console.ReadLine();
            }
            else if (answer.Equals("private"))
            {
                Console.WriteLine("Your Customs Clearance charges will be $275.00.");
                Console.ReadLine();
                Console.WriteLine("Your Terminal Fees will be $75.00");
                Console.ReadLine();

                //Crate Dimensions Entered
                Console.WriteLine("Please enter the crate Length for your incoming shipment: ");
                double l = new double();
                l = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the crate Width for your incoming shipment: ");
                double w = new double();
                w = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the crate Height for your incoming shipmet");
                double h = new double();
                h = double.Parse(Console.ReadLine());

                double totalDims = new double();
                totalDims = l * w * h;
                double volKg = new double();
                volKg = totalDims / 366;

                Console.WriteLine("Your total Vol Kg is {0:0.00}", +volKg);
                Console.ReadLine();

                Console.Write("Are there any additional crates? ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Please enter Trade or Private client.");
                Console.ReadLine();
            }    
        }
    }
}
