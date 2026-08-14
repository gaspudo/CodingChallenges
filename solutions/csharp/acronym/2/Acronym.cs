using System.Text;
using System.Text.RegularExpressions;

public static class Acronym
{
         public static string Abbreviate(string phrase)
    {
        string limpa = phrase.Replace("'", "");
        string frase = Regex.Replace(limpa, @"[^a-zA-Z0-9\s]", " ");
        StringBuilder resultado = new();
        char ultimoCaracter = ' ';
        foreach (char letra in frase) {
            if (!char.IsLetter(ultimoCaracter) && char.IsLetter(letra))
            {
                resultado.Append(letra);
            }
            ultimoCaracter = letra;
        }
             return resultado.ToString().ToUpper();  
    }
}
