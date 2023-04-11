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

string[] palabrasFacil = { "perro", "gato", "oso", "pato", "loro" };
string[] palabrasIntermedio = { "antibiotico", "jirafa", "pelota", "computadora", "teclado" };
string[] palabrasDificil = { "electroencefalografista ", "otorrinolaringólogo ", "electrocardiograma ", "paralelepípedo ", "mjolnir " };
string[] palabras = {};

Console.WriteLine("Bienvenido al juego del Ahorcado");
Console.WriteLine(@"Seleccione un nivel de dificultad:
                   1. Fácil
                   2. Intermedio
                   3. Difícil");

Console.Write("Ingrese un número: ");
int nivel = int.Parse(Console.ReadLine());

switch (nivel){
    case 1:
        palabras = palabrasFacil;
        break;
    case 2:
        palabras = palabrasIntermedio;
        break;
    case 3:
        palabras = palabrasDificil;
        break;
}



Random rnd = new Random();
string palabra = palabras[rnd.Next(0, palabras.Length)];
char[] letrasCorrectas = new char[palabra.Length];

for (int i = 0; i < palabra.Length; i++){
    letrasCorrectas[i] = '_';
}

int intentos = 6;

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


