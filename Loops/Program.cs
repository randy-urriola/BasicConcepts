int TotalJugador = 0;
int TotalDealer = 0;
int num;
string Message;
string controlOtraCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();

while(true){
    TotalJugador = 0;
    TotalDealer = 0;
        switch (switchControl){
            case "menu":
                Console.WriteLine("Welcome to my C A S I N O");
                Console.WriteLine("Write 21 to start");
                switchControl = Console.ReadLine();
                break;

            case "21":
                do
                {
                    num = random.Next(1,12);
                    TotalJugador += num;
                    Console.WriteLine("Take your card player, ");
                    Console.WriteLine($"you've got: {num} ");
                    Console.WriteLine("Do you want another card?");
                    controlOtraCarta = Console.ReadLine();
                } while (controlOtraCarta.ToLower() == "si" || controlOtraCarta.ToLower() == "yes");

                TotalDealer = random.Next(12,23);
                Console.WriteLine($"The dealer have: {TotalDealer}!");

                if (TotalJugador > TotalDealer && TotalJugador < 22)
                {
                    Message = "Congrats, You win against the dealer in the BlackJack";
                    switchControl = "menu";
                }
                else if (TotalJugador > 21)
                {
                    Message = "Lost, you have more than 21";
                    switchControl = "menu";
                }
                else if (TotalJugador <= TotalDealer)
                {
                    Message = "You lost against the dealer";
                    switchControl = "menu";
                }
                else
                {
                    Message = "Invalid condition";
                }

                Console.WriteLine(Message);

            break;
            default:
                Console.WriteLine("Error in input value  - C A S I N O -");
                break;
        }
    
}


