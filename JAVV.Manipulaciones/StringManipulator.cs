using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAVV.Manipulaciones
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            // Implementa la inversión de la cadena
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Convierte la cadena a un array de caracteres
            char[] charArray = input.ToCharArray();
            // Invierte el array de caracteres
            Array.Reverse(charArray);
            // Crea una nueva cadena a partir del array invertido
            return new string(charArray);
        }

        public string RemoveSpaces(string input)
        {
            // Implementa la eliminación de espacios en blanco
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Usa el método Replace para sustituir todos los espacios por una cadena vacía
            return input.Replace(" ", string.Empty);
        }
    }
}