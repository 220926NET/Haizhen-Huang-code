
int guessChance = 6;
string answer = "apple";
char[] display = {'-', '-' ,'-', '-','-'};
int counter = 0;

Console.WriteLine("Welcome to Hangman Game!");


while(true){

    Console.WriteLine("Please input a character: ");

    string letter = Console.ReadLine();

    //charAt
    //String.Constains :return boolean value
    Console.WriteLine(answer.Contains(letter));

    if(!answer.Contains(letter)){

        Console.WriteLine("The character isn't in the answer!");
    }
    else{


        int letterIndex = answer.IndexOf(letter);
        display[letterIndex] = answer[letterIndex];

        counter += 1;

        Console.WriteLine(display);

        if(counter == 5){
        break;
    }

    }



}



