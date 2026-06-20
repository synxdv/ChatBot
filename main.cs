using System;
public class Inicio
{

    public static string nombre;
    public static bool chateando = true;
    public static void Main()
    {
        Console.WriteLine("ChatBot: Bienvenid@ soy un chatBot creado por Synx..... Acaba todas las preguntas con ?");
        while (chateando)
        {
            
            Console.WriteLine("> ");
            string entrada = Console.ReadLine();

            //Enviar y recibir la respuesta del bot
            string RespuestaBot = Brain.RespuestasChatBot(entrada);
            Console.WriteLine(RespuestaBot);


  
        }

        
    }


    

}