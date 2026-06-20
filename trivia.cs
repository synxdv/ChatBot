public class Trivia
{

    static Dictionary<String, int> futbol = new Dictionary<string, int>()
    {
        {"¿Cual es el equipo con mas champions?", 0 }
    };

    static Dictionary<String, int> nba = new Dictionary<string, int>()
    {
       
    };

    static Dictionary<String, int> general = new Dictionary<string, int>()
    {

    };

    public static void iniciarTrivia()
    {
        Console.WriteLine("ChatBot: Que tipo de trivia te gustaria? ");
        Console.WriteLine("ChatBot: futbol, NBA o preguntas generales");
        Console.WriteLine(">");
        string decisionTrivia = Console.ReadLine().ToLower().Trim();


        if (decisionTrivia == "futbol")
        {
            triviaFutbol();
        }
        else if (decisionTrivia == "nba")
        {
            Console.WriteLine("ChatBot: Aun no disponible..");
        }
        else if (decisionTrivia == "preguntas generales")
        {
            Console.WriteLine("ChatBot: Aun no disponible..");
        }

    }

    public static void triviaFutbol()
    {
        Random rd = new Random();

        Console.WriteLine("ChatBot: Bienvenido a la trivia de futbol. Iniciando las preguntas");
        bool enTrivia = true;

        while (enTrivia)
        {
            int seleccionPregunta = rd.Next(0, futbol.Count);

            if (seleccionPregunta == 0)
            {
                Console.WriteLine($"ChatBot: ¿Cual es el equipo con mas champions?");
                string respuesta = Console.ReadLine().ToLower().Trim();

                if (respuesta == "real madrid")
                {
                    Console.WriteLine("ChatBot: ESOOO, adivinasteee");
                    break;
                }
                else
                {
                    Console.WriteLine("ChatBot: Incorrecto, O lo escribiste mal");
                    break;
                }

            }


        }


    }

    public static void triviaNBA()
    {
        Random rd = new Random();
    }

    public static void triviaGeneral()
    {

    }
}