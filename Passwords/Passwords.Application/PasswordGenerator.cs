using System.Text;

namespace Passwords.Application
{
    public class PasswordGenerator
    {        
        public string Generate(PasswordConfiguration configuration)
        {            
            //StringBuilder result = new StringBuilder();
            
            //for (int i = 0; i < configuration.Length; i++)
            //{
            //    result.Append();
            //}
            if (configuration.Length < configuration.ValidCharactersSets.Count)
            {
                throw new ArgumentException();
            }

            var result = new StringBuilder();
            Random rand = new Random();
            int setLength = 0;

            foreach (var charSet in configuration.ValidCharactersSets)
            {
                setLength = charSet.GetValidCharacters().Length;
                result.Append(charSet.GetValidCharacters()[rand.Next(setLength)]);
            }

            int valCharLength = configuration.ValidCharacters.Length;

            for (int i = 0; i < configuration.Length - result.Length; i++)
            {
                result.Append(configuration.ValidCharacters[rand.Next(valCharLength)]);
            }

            return result.ToString();
        }                
    }
}
