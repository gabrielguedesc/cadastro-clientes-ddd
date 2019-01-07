using System.Text.RegularExpressions;

namespace GG.CadastroClientesDDD.Domain.ValueObjects
{
    class Email
    {
        public static bool Validate(string email)
        {
            return Regex.IsMatch(email, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.IgnoreCase);
        }
    }
}
