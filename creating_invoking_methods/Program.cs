/*
 * Creating method
 * Invoking method
 * Debugging
 */


using System;

namespace creating_invoking_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SmallPizzaPrice = 100;
            const double MediumPizzaPrice = 200;
            const double LargePizzaPrice = 300;

            // Method to take a pizza order with size and quantity as parameters
             void TakePizzaOrder(string size, int quantity)
            {
                double totalCost = CalculateTotalCost(size, quantity);
                Console.WriteLine($"Order confirmed: {quantity} {size} pizza(s). Total cost: ${totalCost:F2}");
            }

            // Method to calculate the total cost based on the pizza size and quantity
             double CalculateTotalCost(string size, int quantity)
            {
                double pizzaPrice = GetPizzaPrice(size);
                return pizzaPrice * quantity;
            }

            // Helper method to get the price of a single pizza based on its size
             double GetPizzaPrice(string size)
            {
                switch (size.ToLower())
                {
                    case "small":
                        return SmallPizzaPrice;
                    case "medium":
                        return MediumPizzaPrice;
                    case "large":
                        return LargePizzaPrice;
                    default:
                        throw new ArgumentException("Invalid pizza size. Available sizes: small, medium, large.");
                }
            }

            //Order a pizza
           
            Console.WriteLine("order placed find the details below");
            TakePizzaOrder("small", 3);

        }
    
    }
}

