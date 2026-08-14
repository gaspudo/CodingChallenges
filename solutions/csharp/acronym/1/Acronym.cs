using System.Text;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        StringBuilder resultado = new();
                char ultimoCaracter = ' ';
                foreach (char letra in phrase) {
                    if (!char.IsLetter(ultimoCaracter) && char.IsLetter(letra) && ultimoCaracter != '\'')
                        {
                            resultado.Append(letra);
                        }
                    ultimoCaracter = letra;
                }
                return resultado.ToString().ToUpper();  
    }
}