//Kenneth Fujimura
//09-12-2022 @ 9:48pm
//Mini Challenge # 2 - Add 2 Numbers
//Console program greets the user, takes in two numbers as inputs, converts those numbers to integers, adds the numbers, and returns the sum value to the user.
//Peer Review by: see mini challenge #1


Console.Clear();
Console.WriteLine("Let's add two numbers!");

//play again while loop
bool playAgain = true;
while (playAgain == true) {
    //variable declaration
    string stringNum1;
    string stringNum2;

    bool isConverted1 = false;
    bool isNumber1;
    int num1 = 0;

    bool isConverted2 = false;
    bool isNumber2;
    int num2 = 0;

    //first number input prompt with data verification
    Console.WriteLine("Enter the first number you wish to add: ");
    while (!isConverted1) {
        stringNum1 = Console.ReadLine();
        isNumber1 = Int32.TryParse(stringNum1, out num1);

        if (isNumber1 == true){
            isConverted1 = true;
        } else {
            Console.WriteLine("Invalid entry. Please enter a whole number or 'Integer'.");
        }
    }
    
    //second number input prompt with data verification
    Console.WriteLine("Enter the second number you wish to add: ");
    while (!isConverted2) {
        stringNum2 = Console.ReadLine();
        isNumber2 = Int32.TryParse(stringNum2, out num2);

        if (isNumber2 == true){
            isConverted2 = true;
        } else {
            Console.WriteLine("Invalid entry. Please enter a whole number or 'Integer'.");
        }
    }
    //old string-to-number conversion method from old code:
    //int num1 = Convert.ToInt32(stringNum1);
    //int num2 = Convert.ToInt32(stringNum2);

    //sum calculation
    int sum = num1 + num2;

    //display result to user
    Console.WriteLine("The sum of your two numbers is: " + sum);

    //play again prompt with input validation
    Console.WriteLine("Would you like to add together another pair of numbers? Y/N");
    bool answerCheck = true;
    while (answerCheck == true) {
        string playAgainInput = Console.ReadLine();
        playAgainInput = playAgainInput.ToLower();
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