using System;

namespace Test
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insert coins on the next few lines.");
                Console.WriteLine("The vending machine works only with 0.1, 0.2, 0.5, 1, and 2 coins.");
                Console.WriteLine("When you finish with inserting, please, type START!");

                string command = Console.ReadLine().ToLower();

                double sumCoins = 0;
                //loop that sums the inserted coins, it also alarms for the unacceptable coins
                while (command != "start")
                {
                    double coin = double.Parse(command);
                    if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                    {
                        sumCoins += coin;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coin}!");
                    }
                    command = Console.ReadLine().ToLower();
                }

                Console.WriteLine("Type the products you want to purchase on the next few lines.");
                Console.WriteLine("You can choose among \"Nuts\", \"Water\", \"Crisps\", \"Soda\" and \"Coke\".");
                Console.WriteLine("Finish purchasing with END!");
                string product = Console.ReadLine().ToLower();

                //the individual price of the product
                double productPrice = 0;
                //total price that is actually paid for all the purchased products
                double paidPrice = 0;
                //money needed in order to be purchased the wanted product, not always they are enough
                double moneyNeeded = 0;
                //loop for the purchased products

                while (product != "end")
                {
                    switch (product)
                    {
                        case "nuts":
                            productPrice = 2.0; moneyNeeded += productPrice;
                            if (moneyNeeded <= sumCoins)
                            {
                                Console.WriteLine("Purchased nuts.");
                                paidPrice = moneyNeeded;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money!");
                                moneyNeeded -= productPrice;
                            }
                            break;

                        case "water":
                            productPrice = 0.7; moneyNeeded += productPrice;
                            if (moneyNeeded <= sumCoins)
                            {
                                Console.WriteLine("Purchased water.");
                                paidPrice = moneyNeeded;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money!");
                                moneyNeeded -= productPrice;
                            }
                            break;

                        case "crisps":
                            productPrice = 1.5; moneyNeeded += productPrice;
                            if (moneyNeeded <= sumCoins)
                            {
                                Console.WriteLine("Purchased crisps.");
                                paidPrice = moneyNeeded;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money!");
                                moneyNeeded -= productPrice;
                            }
                            break;

                        case "soda":
                            productPrice = 0.8; moneyNeeded += productPrice;
                            if (moneyNeeded <= sumCoins)
                            {
                                Console.WriteLine("Purchased soda.");
                                paidPrice = moneyNeeded;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money!");
                                moneyNeeded -= productPrice;
                            }
                            break;

                        case "coke":
                            productPrice = 1.0; moneyNeeded += productPrice;
                            if (moneyNeeded <= sumCoins)
                            {
                                Console.WriteLine("Purchased coke.");
                                paidPrice = moneyNeeded;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money!");
                                moneyNeeded -= productPrice;
                            }
                            break;

                        default: Console.WriteLine("Invalid product!"); break;
                    }

                    product = Console.ReadLine().ToLower();
                }

                Console.WriteLine($"Inserted sum: BGN {sumCoins:F2}");
                Console.WriteLine($"Total price of the purchased products: BGN {paidPrice:F2}");
                //calculating the change
                double change = sumCoins - Math.Abs(paidPrice);
                Console.WriteLine($"Change: BGN {change:F2}");

            }
            catch
            {
                Console.WriteLine("Invalid input! Please, start from the beginning!");
            }
        }
    }
}