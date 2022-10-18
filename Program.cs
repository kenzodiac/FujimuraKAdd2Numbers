//Kenneth Fujimura
//10-18-2022
//GitHub Challenge # 2 - Add 2 Numbers
//Console program greets the user, takes in two numbers as inputs, converts those numbers to integers, adds the numbers, and returns the sum value to the user.
//Peer Review by: 


Console.Clear();
Console.WriteLine("Let's add two numbers!");

//play again while loop
bool playAgain = true;
while (playAgain == true) {
    //variable declaration
    bool isConverted1 = false;
    int num1 = 0;

    bool isConverted2 = false;
    int num2 = 0;

    //first number input prompt with data verification
    Console.WriteLine("Enter the first number you wish to add: ");
    while (!isConverted1) {
        string stringInput = Console.ReadLine();
        bool isNumber = Int32.TryParse(stringInput, out num1);

        if (isNumber == true){
            isConverted1 = true;
        } else {
            Console.WriteLine("Invalid entry. Please enter a whole number or 'Integer'.");
        }
    }
    
    //second number input prompt with data verification
    Console.WriteLine("Enter the second number you wish to add: ");
    while (!isConverted2) {
        string stringInput = Console.ReadLine();
        bool isNumber = Int32.TryParse(stringInput, out num2);

        if (isNumber == true){
            isConverted2 = true;
        } else {
            Console.WriteLine("Invalid entry. Please enter a whole number or 'Integer'.");
        }
    }

    //sum calculation
    int sum = num1 + num2;

    //display result to user
    Console.WriteLine("The sum of your two numbers is: " + sum);

    //play again prompt with input validation
    Console.WriteLine("Would you like to add together another pair of numbers? Y/N");
    bool answerCheck = true;
    while (answerCheck == true) {
        string playAgainInput = Console.ReadLine().ToLower();
        switch (playAgainInput) {
            case "y":
            case "yes":
                answerCheck = false;
                break;
            case "n":
            case "no":
                answerCheck = false;
                playAgain = false;
                break;
            default:
                Console.WriteLine("I do not understand. Please answer with 'Y' for yes, or 'N' for no.");
                answerCheck = true;
                break;
            }
    }
}
Console.WriteLine("Adios!");