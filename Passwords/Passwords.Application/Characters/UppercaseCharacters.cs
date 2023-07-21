

namespace Passwords.Application.Characters
{
    public class UppercaseCharacters : IValidCharactersSet
    {
        public string GetValidCharacters() => "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
}
