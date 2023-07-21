

namespace Passwords.Application.Characters
{
    public class DigitCharacters : IValidCharactersSet
    {
        public string GetValidCharacters() => "0123456789";
    }
}
