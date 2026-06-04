using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder builder = new();
        for (int i = 0; i < identifier.Length; i++) {
            if (identifier[i] == ' ') {
                builder.Append('_');
            } else if (char.IsControl(identifier[i])) {
                builder.Append("CTRL");
            }
            else if (identifier[i] == '-') {
                i++;
                char caracter = char.ToUpper(identifier[i]);
                builder.Append(caracter);
            } else if (!char.IsLetter(identifier[i]) || (identifier[i] >= 'α' && identifier[i] <= 'ω')) {
                continue;            
            } else {
                builder.Append(identifier[i]);
            }
        }

        return builder.ToString();
    }
}
