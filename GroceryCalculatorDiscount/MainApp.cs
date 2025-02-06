using System;
using System.Collections;

namespace GroceryCalc
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // Initializes the inventory, User Cart, and Grocery Discounr Calculator 
            StockProductInventory inventory = new StockProductInventory();
            UserCart userCart = new UserCart();
            GroceryCalcSystem groceryCalc = new GroceryCalcSystem(userCart, inventory);

            inventory.AddProduct(1, "Apple", 1.0m);
            inventory.AddProduct(2, "Brush", 5.05m);
            inventory.AddProduct(3, "Mirror", 3.20m);
            inventory.AddProduct(4, "Pen", 11.06m);
            inventory.AddProduct(5, "Bag", 110.08m);

            Console.WriteLine("\nWelcome to the Grocery Store!");
            Console.Write("-----------------------------");

            while (true)
            {
                try
                {
                    Console.WriteLine("\n     AVAILABLE PRODUCTS");
                    Console.WriteLine("-----------------------------");
                    inventory.DiplayAllProducts();

                    Console.Write("Enter the choosen product: ");
                    int productChoice = int.Parse(Console.ReadLine());

                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    userCart.AddProduct(inventory.GetProductById(productChoice), quantity);


                    userCart.DisplayAllProducts();

                    groceryCalc.CalcTotalPriceBeforeDiscount();
                    groceryCalc.DisplayTotalPriceBeforeDiscount();


                    Console.Write("Do you want to add another item? (yes/no): ");
                    string response = Console.ReadLine().ToLower();

                    if (response == "no")
                        break;
                    else if (response == "yes")
                        continue;
                    else
                        throw new Exception();
                }
                catch (Exception) {                 
                    Console.WriteLine("Please enter a valid input...");
                }

            }


            groceryCalc.CalcTotalPrice();


            // Display receipt
            Console.Clear();
           

            userCart.DisplayAllProducts();

            groceryCalc.CalcTotalPriceBeforeDiscount();
            groceryCalc.CalcDiscount();
            groceryCalc.CalcTotalPrice();

            groceryCalc.DisplayReceipt();


            //new purchase or exit
            try
            {
                Console.Write("Do you want to make a new purchase? (yes/no): ");
                string newPurchaseResponse = Console.ReadLine().ToLower();

                if (newPurchaseResponse == "yes")
                    Main(args); // Restart the application (pwede diay ni Whhahahaha
                else if (newPurchaseResponse == "no")
                    Console.WriteLine("Thank you for shopping with us! Goodbye!");
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid input...");
            }

        }
    }
}