/* 
 C# basics code
 Written by: Rajat Pawan Tarade
 Date: 27 Sept 2022

 Discription: In this program, I have implemented a Vending Machine.
 The program starts with displaying the full range of products available saved in an array
 printing them one by one using a 'for' loop. Then it asks the user to choose a product.
 Then the program is frozen using a 'while' loop untill a valid input is received, that is,
 an input between the range of 1 to 6. Once a valid input is received it asks for the quantity 
 and calculates the total bill. 

 This code uses following basic concepts
* User Input
* Formatted Output
* String and Integer Array
* 'For' and 'While' loop
* Branching statements (if, else)
* Products as Objects with methods (OOP)
* Ability to ADD and REMOVE a product
 */

namespace ConsoleApp2
{
    class Program
    {

        public static void Main(string[] args)
        {
            //Array of product names
            string[] products = { "Lays", "Kurkure", "Balaji Chips", "Chitale Bakarwadi", "Kerla Banana Chips" };
            //Array of product prices
            int[] prices = { 20, 25, 10, 50, 15 };
            
            //Basic print statements greeting the user
            System.Console.WriteLine("Welcome to TTT vending machine:");
            System.Console.WriteLine("-------------------------------");

            //Create an array on object 'Product' 
            List<Product> allProducts = new List<Product>();
            
            //Add products to the product array
            //Printing entire menu using FOR loop and formatting
            for (int i = 0; i < products.Length; i++)
            {
                allProducts.Add(new Product(products[i], prices[i]));
                System.Console.WriteLine($"{i + 1}. Buy {allProducts[i].name}  at {allProducts[i].price}");
            }
            System.Console.WriteLine($"6. To exit");

            // Ask user for input
            System.Console.WriteLine("Enter your choice: ");

            // Default input is string which has to be converted to Integer
            int choice = int.Parse(System.Console.ReadLine());

            //Dont go forward till valid choice is entered
            while (choice > 6)
            {
                System.Console.WriteLine("Invalid choice! Please select from 1 to 6");
                choice = int.Parse(System.Console.ReadLine());
            }

            // Exit if choice is '6'
            if (choice == 6)
            {
                System.Environment.Exit(1);
            }

            //Calculate the bill
            else
            {
                System.Console.WriteLine("Please Enter the Quantity: ");
                int qty = int.Parse(System.Console.ReadLine());

                // Use 'buy' method from product to calculate bill
                int bill = allProducts[choice].buy(qty);

                System.Console.WriteLine($"Your bill is {bill}");
            }
        }
    }
}
