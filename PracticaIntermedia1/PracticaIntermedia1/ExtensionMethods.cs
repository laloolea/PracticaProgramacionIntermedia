using System;
using System.Text.RegularExpressions;

namespace PracticaIntermedia1
{
    internal static class ExtensionMethods
    {
        public static dynamic FirstElement(this Map<DerivatedClassAbstract> map)
        {
            return map[0];
        }

        public static bool Validate(this string frase)
        {
            bool resultIsMatch = Regex.IsMatch(frase, @"^[A-Z][a-z]{3}\d{4}$");
            //question can I change it like this? : @"^[A-Z][a-z]{3}[0-9]{4}$"
            return resultIsMatch;
        }
    }
}
