using Passwords.Application.Characters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords.Application
{
    internal class PasswordConfiguration
    {
        public int Length { get; private set; }
        public List<IValidCharactersSet> validCharactersSets;
        public void setLength(int length)
        {
            Length = length;
        }

        public void AddCharactersSet(IValidCharactersSet validCharactersSet)
        {
            validCharactersSets.Add(validCharactersSet);
        }


    }
}
