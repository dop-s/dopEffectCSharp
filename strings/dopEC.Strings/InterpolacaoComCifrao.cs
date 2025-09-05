namespace dopEC.Strings
{
    public class InterpolacaoComCifrao
    {
        public static void stringComCifrao(StringEntity text)
        {
            Console.Write("Interpolação de String c/ `$`: ");
            Console.WriteLine($"{text.Text}");
        }
    }
}
