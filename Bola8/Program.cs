// See https://aka.ms/new-console-template for more information

List<string> respuestas = new List<string>() {
                "Es cierto",
                "Es decididamente así", 
                "Sin lugar a dudas",
                "Sí, definitivamente",
                "Puedes confiar en ello",
                "Como yo lo veo, sí",
                "Lo más probable",
                "Perspectiva buena",
                "Sí",
                "Las señales apuntan a que sí",
                "Respuesta confusa, vuelve a intentarlo",
                "Vuelve a preguntar más tarde",
                "Mejor no decirte ahora",
                "No se puede predecir ahora",
                "Concéntrate y vuelve a preguntar",
                "No cuentes con ello",
                "Mi respuesta es no",
                "Mis fuentes dicen que no",
                "Las perspectivas no son muy buenas",
                "Muy dudoso"
            };
Random rnd = new Random();

Console.WriteLine("Bienvenido a la Bola 8. Hazme una pregunta y te daré una respuesta.");
Console.Write("Pregunta: ");
string pregunta = Console.ReadLine();

Console.WriteLine("La Bola 8 dice: " + respuestas[rnd.Next(respuestas.Count)]);
Console.WriteLine("¿Otra pregunta? Si/No");

String rta = Console.ReadLine().ToLower();

while (rta.Equals("si")){
    Console.Write("Pregunta: ");
    pregunta = Console.ReadLine();

    Console.WriteLine("La Bola 8 dice: " + respuestas[rnd.Next(respuestas.Count)]);
    Console.WriteLine("¿Otra pregunta? Si/No");
    rta = Console.ReadLine().ToLower();
}
