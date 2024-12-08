
//  Author: PHNO - Technologist | Postgraduate
//  Release Date: 08/12/2024
//  Version: 0.0.0.4v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algorithm: Sizing and Calculation for Photovoltaic System in the area of ​​Photovoltaic Solar Energy, built for students and professionals in electrical engineering and related areas, such as renewable energies.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Sizing_and_Calculation_for_Photovoltaic_System
{
    class Program
    { // classe

        public static void Main(string[] args)
        {

            while (true)
            {
                // class, method, string
                Console.WriteLine("\n");
                Console.WriteLine(" Sizing and Calculation for Photovoltaic System ");
                Console.WriteLine("");
                Console.WriteLine("\n\t Menu \n");
                Console.WriteLine("");
                Console.WriteLine("1. Convert - volts [AC] to watts [DC]");
                Console.WriteLine("2. Convert - watts [DC] to volts [AC]");
                Console.WriteLine("3. Calculate the Power of the Modules");
                Console.WriteLine("4. Calculate Weekly Solar Power Generation");
                Console.WriteLine("5. Calculate Monthly Solar Power Generation");
                Console.WriteLine("6. Calculate Annual Solar Power Generation");
                Console.WriteLine("7. Calculate and Size the Number of Modules");
                Console.WriteLine("");
                Console.WriteLine("[8] Info");
                Console.WriteLine("[9] About");
                Console.WriteLine("\n10. Exit");

                Console.WriteLine("\nEnter your choice: "); // choice

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");

                    switch (choice)
                    {
                        case 1:
                            double v2 = 10;
                            Console.WriteLine("Enter how many volts you want to convert to watts: ");
                            double v1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            double resultado = (v1 * v2);
                            Console.WriteLine();
                            Console.WriteLine("The " + (v1) + " volts entered equals " + (resultado) + " watts.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 2:
                            double v4 = 10;
                            Console.WriteLine("Enter how many watts you want to convert to volts: ");
                            double v3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            double resultado2 = (v3 / v4);
                            Console.WriteLine();
                            Console.WriteLine("The " + (v3) + " watts entered equals " + (resultado2) + " volts.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 3:
                            Console.WriteLine("Enter the nominal power of the module in watts: ");
                            int v5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the number of modules: ");
                            int v6 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            int resultado3 = (v5 * v6);
                            Console.WriteLine();
                            Console.WriteLine("The power of the modules will be " + (resultado3) + " watts.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 4:
                            float v11 = 1000;
                            Console.WriteLine("Enter the power of the modules in watts: ");
                            float v7 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the number of hours per day: ");
                            float v8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Enter the number of days per week: ");
                            float v9 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            float v10 = (v7 * v8 * v9);
                            float resultado4 = (v10 / v11);
                            Console.WriteLine("the result will be " + (resultado4) + " kwh/week generation [east/west]");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 5:
                            float v16 = 1000;
                            Console.WriteLine("Enter the power of the modules in watts: ");
                            float v12 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the number of hours per day: ");
                            float v13 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Enter the number of days per month: ");
                            float v14 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            float v15 = (v12 * v13 * v14);
                            float resultado5 = (v15 / v16);
                            Console.WriteLine("the result will be " + (resultado5) + " kwh/month generation [east/west]");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 6:
                            float v21 = 1000;
                            Console.WriteLine("Enter the power of the modules in watts: ");
                            float v17 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the number of hours per day: ");
                            float v18 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("Enter the number of days per year: ");
                            float v19 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            float v20 = (v17 * v18 * v19);
                            float resultado6 = (v20 / v21);
                            Console.WriteLine("the result will be " + (resultado6) + " kwh/year generation [east/west]");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 7:
                            Console.WriteLine("Enter the Calculated System Power (Pfv[BR]) in watts: ");
                            float v22 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the module's nominal power in watts: ");
                            float v23 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            // float resultado7 = (v22 / v23);
                            int resultado7 = Convert.ToInt32(v22 / v23); // convert to int to get a best result, because its printing a periodic dism
                            Console.WriteLine("The maximum number of modules for this dimensioning is " + (resultado7) + " photovoltaic panels.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 8:
                            Clear();
                            Console.WriteLine();
                            Console.WriteLine("Info");
                            Console.WriteLine();
                            Console.WriteLine("To convert volts to watts, multiply the volts by 10.");
                            Console.WriteLine("To convert watts to volts, divide the watts by 10.");
                            Console.WriteLine("To calculate the power of the modules, multiply the nominal power of the module by the number of modules.");
                            Console.WriteLine("To calculate the weekly generation, use the calculation (power of the modules) x (hours per day) x (days per week) ");
                            Console.WriteLine("and the result will be in watts hour and then to get them in kwh we will divide by 1000 to convert to kwh, as calculated in 4 option in this algorithm.");
                            Console.WriteLine("To calculate the monthly generation, use the calculation (power of the modules) x (hours per day) x (days per month) ");
                            Console.WriteLine("and the result will be in watts hour and then to get them in kwh we will divide by 1000 to convert to kwh, as calculated in 5 option in this algorithm.");
                            Console.WriteLine("To calculate the annual generation, use the calculation (power of the modules) x (hours per day) x (days per year) ");
                            Console.WriteLine("and the result will be in watts hour and then to get them in kwh we will divide by 1000 to convert to kwh, as calculated in 6 option in this algorithm.");
                            Console.WriteLine("To calculate and size the number of modules that composes a solar panel, we use the following calculation: ");
                            Console.WriteLine("Calculated system power (Pfv[BR]) in watts divided by the nominal power of the module in watts = the number of modules.");
                            Console.WriteLine("To convert 1kwh to 1wh, simply do the calculation, e.g.: 73kwh to wh will be 73000 wh.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 9:
                            Clear();
                            Console.WriteLine();
                            Console.WriteLine("Algorithm: Sizing and Calculation for Photovoltaic System");
                            Console.WriteLine();
                            Console.WriteLine("Author: PHNO");
                            Console.WriteLine("Release Date: 08/12/2024");
                            Console.WriteLine("Version: 0.0.0.4v");
                            Console.WriteLine("Replit: @PHNO, @PHREPLIT");
                            Console.WriteLine("E-mail: phreplit@gmail.com");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                        case 10:
                            Exit();
                            break;
                        default:
                            Console.WriteLine("Error, Wrong Option!");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return menu...");
                            Console.ReadKey();
                            Clear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, system failure.");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return menu...");
                    Console.ReadKey();
                    Clear();
                }
            }
        }
        public static void Exit()
        { // exit method
            Console.WriteLine();
            Console.WriteLine(" Finished Algorithm! ");
            System.Environment.Exit(-1);
            return;
        }
        public static void Clear()
        { // method 
            Console.Clear();
            return;
        }
    }
}
