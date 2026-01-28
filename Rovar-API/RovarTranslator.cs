using System.Text;

namespace RovarApi
{
    public class RovarTranslator
    {
        private const string Consonants = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";

        // Kryptera: "b" -> "bob"
        public string ToRovarsprak(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            var sb = new StringBuilder();
            foreach (char c in input)
            {
                if (Consonants.Contains(c))
                {
                    // Lägger till konsonant + "o" + konsonanten igen
                    sb.Append(c + "o" + c.ToString().ToLower());
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        // Avkryptera: "bob" -> "b"
        public string FromRovarsprak(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            foreach (char c in Consonants)
            {
                // Ersätter t.ex. "bob" med "b", "coc" med "c" osv.
                // Obs: Enklast är att loopa igenom alla konsonanter och ersätta tillbaka.
                string pattern = c + "o" + c.ToString().ToLower();
                input = input.Replace(pattern, c.ToString());
            }
            return input;
        }
    }
}