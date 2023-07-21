using Passwords.Application.Characters;
using System.Text;

namespace Passwords.Application
{
    public class PasswordConfiguration
    {
        private int length;
        private List<IValidCharactersSet> validCharactersSets;            

        public int Length
        {
            get { return length; }
            set
            {
                if (value >= 6 && value <= 20)
                    length = value;
            }
        }

        public string ValidCharacters { get; private set; } 
        public IReadOnlyList<IValidCharactersSet> ValidCharactersSets
        {
            get { return validCharactersSets; }
        }


        public PasswordConfiguration()
        {
            length = 6;
            validCharactersSets = new List<IValidCharactersSet>() { new LowercaseCharacters() };
            ValidCharacters = CharactersSetToString();
        }

        protected string CharactersSetToString()
        {
            var result = new StringBuilder();
            foreach (IValidCharactersSet validCharactersSet in validCharactersSets)
            {
                result.Append(validCharactersSet.GetValidCharacters());
            }

            return result.ToString();
        }
        protected void Update()
        {
            ValidCharacters = CharactersSetToString();
        }

        public void AddCharactersSet(IValidCharactersSet validCharactersSet)
        {
            if (!validCharactersSets.Contains(validCharactersSet))
                validCharactersSets.Add(validCharactersSet);
            Update();
        }

        public void RemoveCharactersSet(IValidCharactersSet validCharactersSet)
        {
            if (validCharactersSets.Contains(validCharactersSet) && validCharactersSets.Count > 1)
                validCharactersSets.Add(validCharactersSet);
            Update();
        }
    }
}
