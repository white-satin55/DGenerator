using Passwords.Application;
using Passwords.Application.Characters;

public class Program
{
    public static void Main(string[] args)
    {
        var conf = new PasswordConfiguration();
        conf.Length = 10;
        conf.AddCharactersSet(new UppercaseCharacters());
        conf.AddCharactersSet(new DigitCharacters());

        var gen = new PasswordGenerator();
        var pass = gen.Generate(conf);

        Console.WriteLine(pass);
    }
}