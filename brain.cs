using System.Collections.Generic;

public class Brain
{

    static Dictionary<string, string> respuestas = new Dictionary<string, string>() {
        {"hola", "ChatBot: Holaaa. En que puedo ayudarte?" },
        {"como estas?", "ChatBot: Estoy listo para ayudarte!!" }
    }; 
    

    public static string RespuestasChatBot(string conenido)
    {
        string mensajeUsuario = conenido.ToLower().Trim();

        if (respuestas.ContainsKey(mensajeUsuario))
        {
            return respuestas[mensajeUsuario];
         
        }
        else
        {
            return "ChatBot: No entiendo lo que quieres decir";
           
        }
    }

}