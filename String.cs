using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtilitariiosDiasUteisEeStringNetFramework
{
    public class String
    {
        public static bool VerifSeEstCertNomeESoLetrasSemEspaco(string nome)
        {
            if (nome.Length < 2)
                return false;
            bool temCaraterEspecial = Regex.IsMatch(nome, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));
            if (temCaraterEspecial || string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            {
                return false;
            }
            else
            {
                if (nome.All(char.IsLetter))
                    return true;
                else
                    return false;
            }
        }
        public static string NomeBom(string nome)
        {
            nome.Trim();
            string[] temp = nome.Split(' ');
            for (int i = 0; i < temp.Length; i++)
                temp[i] = temp[i].Substring(0, 1).ToUpper() + temp[i].Substring(1);
            nome = string.Join(" ", temp);// juntar carateres em uma unica string, o da frente e o separador
            return nome;
        }
    }
}
