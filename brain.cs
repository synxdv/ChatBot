using System.Collections.Generic;

public class Brain
{

    static Dictionary<string, string> respuestas = new Dictionary<string, string>() {
        {"hola", "ChatBot: Holaaa. En que puedo ayudarte?" },
        {"como estas?", "ChatBot: Estoy listo para ayudarte!!" },
        {"ultimo campeon del mundo", "ChatBot: Argentina!! " },
        {"barcelona o real madrid?", "ChatBot: Barcelona, obvio" }

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