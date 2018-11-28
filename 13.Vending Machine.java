import java.util.Scanner;

public class VendingMachine {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try {
            System.out.println("Insert coins on the next few lines.");
            System.out.println("The vending machine works only with 0.1, 0.2, 0.5, 1, and 2 coins.");
            System.out.println("When you finish with inserting, please, type START!");
            String command = scanner.nextLine().toLowerCase();

            double sumCoins = 0;

            //loop that sums the inserted coins, it also alarms for the unacceptable coins
            while (!("start".equals(command))) {
                double coin = Double.parseDouble(command);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2) {
                    sumCoins += coin;
                } else {
                    System.out.println("Cannot accept " + coin + "!");
                }
                command = scanner.nextLine().toLowerCase();
            }

            System.out.println("Type the products you want to purchase on the next few lines.");
            System.out.println("You can choose among \"Nuts\", \"Water\", \"Crisps\", \"Soda\" and \"Coke\".");
            System.out.println("Finish purchasing with END!");
            String product = scanner.nextLine().toLowerCase();

            //the individual price of the product
            double productPrice = 0;
            //total price that is actually paid for all the purchased products
            double paidPrice = 0;
            //money needed in order to be purchased the wanted product, not always they are enough
            double moneyNeeded = 0;
            //loop for the purchased products

            while (!("end".equals(product))) {

                if ("nuts".equals(product)) {
                    productPrice = 2.0;
                    moneyNeeded += productPrice;
                    if (moneyNeeded <= sumCoins) {
                        System.out.println("Purchased nuts.");
                        paidPrice = moneyNeeded;
                    } else {
                        System.out.println("Sorry, not enough money!");
                        moneyNeeded -= productPrice;
                    }

                } else if ("water".equals(product)) {
                    productPrice = 0.7;
                    moneyNeeded += productPrice;
                    if (moneyNeeded <= sumCoins) {
                        System.out.println("Purchased water.");
                        paidPrice = moneyNeeded;
                    } else {
                        System.out.println("Sorry, not enough money!");
                        moneyNeeded -= productPrice;
                    }

                } else if ("crisps".equals(product)) {
                    productPrice = 1.5;
                    moneyNeeded += productPrice;
                    if (moneyNeeded <= sumCoins) {
                        System.out.println("Purchased crisps.");
                        paidPrice = moneyNeeded;
                    } else {
                        System.out.println("Sorry, not enough money!");
                        moneyNeeded -= productPrice;
                    }
                } else if ("soda".equals(product)) {
                    productPrice = 0.8;
                    moneyNeeded += productPrice;
                    if (moneyNeeded <= sumCoins) {
                        System.out.println("Purchased soda.");
                        paidPrice = moneyNeeded;
                    } else {
                        System.out.println("Sorry, not enough money!");
                        moneyNeeded -= productPrice;
                    }
                } else if ("coke".equals(product)) {
                    productPrice = 1.0;
                    moneyNeeded += productPrice;
                    if (moneyNeeded <= sumCoins) {
                        System.out.println("Purchased coke.");
                        paidPrice = moneyNeeded;
                    } else {
                        System.out.println("Sorry, not enough money!");
                        moneyNeeded -= productPrice;
                    }
                } else {
                    System.out.println("Invalid product!");
                }

                product = scanner.nextLine().toLowerCase();
            }

            System.out.printf("Inserted sum: BGN %.2f\n", sumCoins);
            System.out.printf("Total price of the purchased products: BGN %.2f\n", paidPrice);
            //calculating the change
            double change = sumCoins - Math.abs(paidPrice);
            System.out.printf("Change: BGN %.2f\n", change);

        } catch (Exception ex) {
            System.out.println("Invalid input! Please, start from the beginning!");
        }
    }
}