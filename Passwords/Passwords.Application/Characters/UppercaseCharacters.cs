using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords.Application.Characters
{
    internal class UppercaseCharacters : IValidCharactersSet
    {
        public string GetValidCharacters() => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
}
