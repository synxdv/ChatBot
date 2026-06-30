using System.Collections.Generic;
using System.Timers;
using System.IO;
public class Brain
{

   static int minutos = DateTime.Now.Minute;
   static int hora = DateTime.Now.Hour;
 

    static Dictionary<string, string> respuestas = new Dictionary<string, string>() {
        {"hola", "ChatBot: Holaaa. En que puedo ayudarte?" },
        {"como estas?", "ChatBot: Estoy listo para ayudarte!!" },
        {"ultimo campeon del mundo", "ChatBot: Argentina!! " },
        {"barcelona o real madrid?", "ChatBot: Barcelona, obvio" },
        {"consejo", "ChatBot: 1. Todas las preguntas que quieras hacer acabalas con ?\n2.Escribe Trivia para jugar trivia"  },
        {"hora", $"ChatBot: la hora es {hora}:{minutos}" },
        {"futbol", "ChatBot: El deporte rey" },
        {"amigo", "ChatBot: Para servirte rey" },
        {"wikipedia", "ChatBot: Aca te dejo el link de wikipedia!! https://wikipedia.org/" },
        {"lvp", "ChatBot: Obra maestra" },
        {"synx", "ChatBot: Mi creador, el mejor de todos" }


    }; 
    

    public static string RespuestasChatBot(string conenido)
    {
        string mensajeUsuario = conenido.ToLower().Trim();

        if (respuestas.ContainsKey(mensajeUsuario))
        {
            return respuestas[mensajeUsuario];
         
        }
        else if(mensajeUsuario == "trivia")
        {
            Trivia.iniciarTrivia();
            return "ChatBot: Perfecto, la trivia acabo";
        }
        else if (mensajeUsuario == "clear")
        {
            Console.Clear();
            return "ChatBot: Consola limpiada correctamente...";
        }
        else
        {
            return "ChatBot: No entiendo lo que quieres decir";

        }
    }

}