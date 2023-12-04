namespace Vsite.CSharp.ZajedničkaSvojstvaTipova
{
    public static class Util
    {
        public static void IspisNaslova(string naslov)
        {
            System.Console.WriteLine(new string('*', naslov.Length));
            System.Console.WriteLine(naslov);
        }
    }
}
