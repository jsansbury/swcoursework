
using System;
public class Test
{

    static void Main(string[] args)
    {
        string Result; // declaring string variable results
        Console.WriteLine("Please enter your name"); // display to user interface
        String inputN = Console.ReadLine(); // setting string variable inputN to the value of Console.ReadLine()         
        Console.WriteLine("please enter your units"); // display to user interface
        string units = Console.ReadLine(); // setting the value of varible string units to the value of Console.ReadLine()



        int Units = Int32.Parse(units); // changes string variable unputU into integer Units



        if (Units <= 200) // if unite entered are less than or equal to 200 run if statement

        {

            Result = ((inputN) + " Amount Due " + (Units * 6) + " Pence ");
            Console.WriteLine(Result); // displays to user interface the users name amount due and units muliplied by 6
        }

        if ((Units > 200) && (Units <= 500)) // if units entered are greater than 200 and less than or equal to 500 run if statement

        {
            Result = ((inputN) + " Amount Due " + (Units * 7) + " Pence ");
            Console.WriteLine(Result);  // displays to user interface the users name amount due and units muliplied by 7
        }
        if ((Units > 500) && (Units <= 700))  // if units entered are greater than 500 and less than or equal to 700 run if statement

        {
            Result = ((inputN) + " Amount Due " + (Units * 8) + " Pence ");
            Console.WriteLine(Result); // displays to user interface the users name amount due and units muliplied by 8
        }

        if (Units > 700) // if units entered are greater than 700 run if statement

        {
            Result = ((inputN) + " Amount Due " + (Units * 9) + " Pence ");
            Console.WriteLine(Result); // displays to user interface the users name amount due and units muliplied by 9
        }


    }
}
}


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

B) 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Select_items
{
    class Program
    {
        static void Main(string[] args)
        {
            Selection();
        }
        static void Selection()
        {
            Console.WriteLine("\n pick one animal ");   // Displays to user interface
            Console.WriteLine("\n1) Lion");   // Displays to user interface
            Console.WriteLine("\n2) Tiger");   // Displays to user interface
            Console.WriteLine("\n3) Leopard"); // Displays to user interface
            Console.WriteLine("\n4) Jaguar");  // Displays to user interface 
            Console.WriteLine("\n  press e to exit ");  // Displays to user interface 


            ConsoleKeyInfo meniuselection;  // defines variable meniuselection as ConsoleKeyInfo
            meniuselection = Console.ReadKey(true); // sets boolean value of meniuselection true, if the correct key is selectedthe programme keeps running and displays switch case that is selected

            switch (meniuselection.KeyChar)
            {
                case '1':
                    Console.WriteLine("\n You have selected Lion "); // displays to user interface    
                    Selection(); // cycles back to the selection program 
                    break; // breaks out of case block 1 and stops code being run

                case '2':
                    Console.WriteLine("\n  You have selected Tiger "); // displays to user interface
                    Selection(); // cycles back to the selection program 
                    break; // breaks out of case block 2 and stops code being run

                case '3':
                    Console.WriteLine("\n  You have selected Leopard "); // displays to user interface
                    Selection(); // cycles back to the selection program 
                    break; // breaks out of case block 3 and stops code being run

                case '4':
                    Console.WriteLine("\n You have selected Jaguar "); // displays to user interface
                    Selection(); // cycles back to the selection program 
                    break; // breaks out of case block 3 and stops code being run
                case 'e':
                    Console.WriteLine("You chose to exit. Goodbye!"); // displays to user interface
                    System.Environment.Exit(0); // closes the programme
                    break; // breaks out of case block 3 and stops code being run



            }
        }


    


















