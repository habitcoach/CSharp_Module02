using System;

namespace ExceptionModule02
{
    class Program
    {
        static double CalculateTotalCost(int itemNumber, int quantity)
        {
            MenuItem selectedItem;

            if (itemNumber <= 0 || itemNumber > 3)
            {
                throw new ArgumentException("Invalid item number.");
               
            }

            switch (itemNumber)
            {
                case 1:
                    selectedItem = new MenuItem("Burger", 100);
                    break;
                case 2:
                    selectedItem = new MenuItem("Pizza", 200);
                    break;
                case 3:
                    selectedItem = new MenuItem("Salad", 300);
                    break;
                default:
                    throw new ArgumentException("Invalid item number.");
            }

            return CalculateTotalCost(selectedItem, quantity);
        }

        // Overloaded method to calculate the total cost with optional parameters
        static double CalculateTotalCost(MenuItem item, int quantity = 1)
        {
            return item.Price * quantity;
        }

        // Method to print order details with named arguments
        static void PrintOrderDetails(int item, int qty, double cost)
        {
            //throw new InvalidOperationException(""); 
            Console.WriteLine("\nOrder Details:");
            Console.WriteLine($"Item: {item}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Total Cost: ${cost}");
        }

        // Method to calculate the total cost with discount using output parameter
        static void CalculateTotalCostWithDiscount(double totalCost, out double discountedAmount)
        {

            // Applying 10% discount for demonstration purposes
            discountedAmount = totalCost * 0.9;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Restaurant!");

            // Define the menu items with their respective prices
            MenuItem item1 = new MenuItem("Burger", 100);
            MenuItem item2 = new MenuItem("Pizza", 200);
            MenuItem item3 = new MenuItem("Salad", 300);

            // Display the menu
            Console.WriteLine("Menu:");
            Console.WriteLine($"1. {item1.Name} - ${item1.Price}");
            Console.WriteLine($"2. {item2.Name} - ${item2.Price}");
            Console.WriteLine($"3. {item3.Name} - ${item3.Price}");

            try
            {

                // Let the customer place an order
                Console.Write("Enter the item number to order: ");
                int itemNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter the quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                // Calculate the total cost using overloaded methods
                double totalCost = CalculateTotalCost(itemNumber, quantity);

                // Calculate the total cost with discount using output parameter
                double discountedAmount;
                CalculateTotalCostWithDiscount(totalCost, out discountedAmount);

                // Display the order details with named arguments
                PrintOrderDetails(item: itemNumber, qty: quantity, cost: totalCost);

                // Display the total cost and discounted amount

                Console.WriteLine($"Discounted amount: ${discountedAmount}");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numeric values.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: Invalid item number. Please choose a valid item from the menu.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: The entered quantity or item number is too large.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            finally {

                Console.WriteLine("Cleaning resource!!!");
                MenuItem disposing = new MenuItem();
                disposing.Dispose();
            }

        }



        // Definition of MenuItem class

    }

     class MenuItem:IDisposable
    {
        public string Name { get; }
        public double Price { get; }

        public MenuItem()
        {

        }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public  void Dispose()
        {
            Console.WriteLine("closing existing connections");
            Console.WriteLine("connection cloesed");
        }
        
    }


}


