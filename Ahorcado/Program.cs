// See https://aka.ms/new-console-template for more information

static void DibujarAhorcado(int intentos)
{
    switch (intentos)
    {
        case 6:
            Console.WriteLine(@"
                 _____
                |     |
                |     
                |      
                |      
                |      
                |      
                |___");
            break;
        case 5:
            Console.WriteLine(@"
                 _____
                |     |
                |     O
                |      
                |      
                |      
                |      
                |___");
            break;
        case 4:
            Console.WriteLine(@"
                 _____
                |     |
                |     O
                |     |
                |     |
                |      
                |      
                |___");
            break;
        case 3:
            Console.WriteLine(@"
                 _____
                |     |
                |     O
                |    /|
                |     |
                |      
                |      
                |___");
            break;
        case 2:
            Console.WriteLine(@"
                 _____
                |     |
                |     O
                |    /|\
                |     |
                |      
                |      
                |___");
            break;
        case 1:
            Console.WriteLine(@"
                 _____
                |     |
                |     O
                |    /|\
                |     |
                |    / 
                |      
                |___");
            break;
        case 0:
            Console.WriteLine(@"
                 _____
                |     |
                |     O
                |    /|\
                |     |
                |    / \
                |      
                |___");
            break;
    }
}

string[] palabras = { "perro", "gato", "elefante", "jirafa", "leon" };
Random rnd = new Random();

string palabra = palabras[rnd.Next(0, palabras.Length)];
char[] letrasCorrectas = new char[palabra.Length];

for (int i = 0; i < palabra.Length; i++){
    letrasCorrectas[i] = '_';
}

int intentos = 6;

Console.WriteLine("Bienvenido al juego del Ahorcado");
Console.WriteLine($"La palabra tiene {palabra.Length} letras");

while (intentos > 0){
    Console.WriteLine($"Intentos restantes: {intentos}");
    Console.WriteLine($"Letras adivinadas: {new string(letrasCorrectas)}");
    Console.Write("Ingrese una letra: ");

    char letra = Console.ReadKey().KeyChar;
    Console.WriteLine();
    bool letraAdivinada = false;

    for (int i = 0; i < palabra.Length; i++){
        if (palabra[i] == letra){
            letrasCorrectas[i] = letra;
            letraAdivinada = true;
        }
    }

    if (!letraAdivinada){
        intentos--;
        DibujarAhorcado(intentos);
        Console.WriteLine("Letra incorrecta");
    }
    else{
        Console.WriteLine("Letra correcta");
    }
    
    if (new string(letrasCorrectas) == palabra){
        Console.WriteLine("¡Felicidades, has ganado!");
        return;
    }
}
DibujarAhorcado(0);
Console.WriteLine($"Lo siento, has perdido. La palabra era {palabra}");


