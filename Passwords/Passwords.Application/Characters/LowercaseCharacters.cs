

namespace Passwords.Application.Characters
{
    public class LowercaseCharacters : IValidCharactersSet
    {
        public string GetValidCharacters() => "abcdefghijklmopqrstuvwxyz";

    }
}
