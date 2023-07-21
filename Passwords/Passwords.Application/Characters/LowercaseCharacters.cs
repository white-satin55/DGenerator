using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords.Application.Characters
{
    internal class LowercaseCharacters :  IValidCharactersSet
    {
        public string GetValidCharacters() => "abcdefghijklmopqrstuvwxyz";

    }
}
