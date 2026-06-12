// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int TotalJugador = 20;
int TotalDealer = 15;
string Message;

if(TotalJugador > TotalDealer && TotalJugador < 22)
{
    Message = "Felicidades, Ganaste al dealer en el BlackJack";
} else if (TotalJugador > 21)
{
    Message = "Perdiste, te pasaste de 21";
} else if(TotalJugador <= TotalDealer)
{
    Message = "Perdiste contra el dealer";
} else
{
    Message = "Condición no válida";
}

Console.WriteLine(Message);