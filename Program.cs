using System;

class Alburan_LabExercise1
{
    static void Main()
    {
        // dito po yung user inputted, na kung ilang apples po
        Console.Write("Enter the pieces of apple: ");
        string appleCountInput = Console.ReadLine();
        int appleCount = Convert.ToInt32(appleCountInput);


        // dito po pinrint out po muna dun sa sentence yung user inputted po kanina na pieces of apples then nag user input po ulit for total price of apples
        Console.Write("Enter total price of " + appleCount + " apple(s): ");
        string totalPriceInput = Console.ReadLine();
        double totalPrice = Convert.ToDouble(totalPriceInput);


        // dito po pi-nrint out lang po yung total price po, galing dun sa user inputted po kanina
        Console.WriteLine("The total price of " + appleCount + " apple(s) is " + totalPrice);


        // print out po ng original price galing dun po sa total price
        Console.WriteLine("The value of original price is " + totalPrice);


        // dito po ginawa ko po siyang int nalang po yung total price kasi po dun sa nakalagay po wala na po yung decimal so I assume na hindi na po siya double kaya po kinonvert ko po siya into int
        int convertedPrice = (int)totalPrice;


        // dito po print out lang po ng converted price na galing po sa total price pero po na-convert na
        Console.WriteLine("The value of converted price is " + convertedPrice);


        Console.WriteLine();


        // print out lang po
        Console.WriteLine("Press any key to exit.....");
        Console.ReadKey();
    }
}

