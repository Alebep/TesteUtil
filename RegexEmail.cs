using System.Text.RegularExpressions;


namespace UtilitariiosDiasUteisEeStringNetFramework
{
    public class RegexEmail
    {
        public bool Email(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
