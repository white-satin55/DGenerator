using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords.Application.Characters
{
    internal class DigitCharacters : IValidCharactersSet
    {
        public string GetValidCharacters() => "0123456789";
    }
}
