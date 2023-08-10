using System;

public class USSDSimulation {
    // public void Main(){
    //     ShowMainMenu();
    // }

    public void ShowMainMenu(){
        System.Console.WriteLine("Welcome to Jitu Services:");
        System.Console.WriteLine("1. Check Balance");
        System.Console.WriteLine("2. Buy Data Bundles");
        System.Console.WriteLine("3. Transfer Airtime");
        System.Console.WriteLine("4. Exit");

        int selection;
        do{
            System.Console.WriteLine("Please make a selection: ");
        } while (!int.TryParse(Console.ReadLine(), out selection));

        switch (selection){
            case 1:
                CheckBalance();
                break;
            case 2:
                BuyDataBundles();
                break;
            case 3:
                TransferAirtime();
                break;
            case 4:
                System.Console.WriteLine("Exiting...");
                break;
            default:
                System.Console.WriteLine("Invalid choice.Please try again.");
                ShowMainMenu();
                break;
        }
    }
    public void CheckBalance(){
        System.Console.WriteLine("Your current balance is 100");
        ShowMainMenu();
    }

    public void BuyDataBundles(){
        System.Console.WriteLine("Choose a data bundle: ");
        System.Console.WriteLine("1. 1GB - 100");
        System.Console.WriteLine("2. 2GB - 200");
        System.Console.WriteLine("3.Go back to main menu");

        int selection;
        do {
            Console.Write("Enter your choice: ");
        } while (!int.TryParse(Console.ReadLine(), out selection));
        switch (selection){
            case 1:
                System.Console.WriteLine("You have bought 1 GB data bundle for 100");
                ShowMainMenu();
                break;
            case 2:
                System.Console.WriteLine("You have bought 2 GB data bundle for 100");
                ShowMainMenu();
                break;
            case 3:
                ShowMainMenu();
                break;
            default:
                System.Console.WriteLine("Invalid choice. Please try again");
                BuyDataBundles();
                break;
        }
        
    }

    public void TransferAirtime(){
        System.Console.WriteLine("Enter phone number: ");
        string phoneNumber = Console.ReadLine();

        System.Console.WriteLine("Enter amount to transfer: ");
        decimal amount;
        while(!decimal.TryParse(Console.ReadLine(), out amount)){
            System.Console.WriteLine("Invalid amount. Please enter a valid number.");
        }
        System.Console.WriteLine($"You have transferred {amount} airtime to {phoneNumber}.");
        ShowMainMenu();
    }
}