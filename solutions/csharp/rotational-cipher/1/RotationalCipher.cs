using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder resultado = new();
            foreach (char c in text)
            {   if(char.IsLetter(c)) {
                    char inicial = char.IsUpper(c) ? 'A' : 'a';
                    int valor = (c - inicial + shiftKey) % 26 + inicial;
                    resultado.Append((char)valor);
                } else {
                resultado.Append(c);
                }
            }
            return resultado.ToString();
    }
}