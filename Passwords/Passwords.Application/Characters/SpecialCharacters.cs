

namespace Passwords.Application.Characters
{
    public class SpecialCharacters: IValidCharactersSet
    {
        public string GetValidCharacters() => "!#$%&'()*+,-./:;<=>?@[]^_`{|}~";
    }
}
