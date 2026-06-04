public static class Bob
{
    public static string Response(string statement)
    {
        string strLimpa = statement.Trim();
        bool digito = strLimpa.All(char.IsDigit);
        bool temLetra = strLimpa.Any(char.IsLetter);
        bool maiusculo = strLimpa == strLimpa.ToUpper();
        bool gritando = maiusculo && temLetra;
        bool pergunta = false;
        if (strLimpa.Length >= 1) {
            pergunta = strLimpa[strLimpa.Length - 1] == '?';
        }
        if (strLimpa == "") return "Fine. Be that way!";
        else if (gritando && pergunta) return "Calm down, I know what I'm doing!";
        else if (gritando) return "Whoa, chill out!";
        else if(pergunta) return "Sure.";

        return "Whatever.";
    }
}